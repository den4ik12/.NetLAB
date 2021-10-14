using System;
using System.Net;
using System.Collections.Concurrent;
using ClassLibraryMountainPeaks;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Server
{
    class Program
    {
        private static ConcurrentDictionary<string, Mountain> _mountains = new();
        static void Main()
        {
            LoadMountains("testSave.json");
            System.Threading.TimerCallback tm = new(AutoSave);
            System.Threading.Timer timer = new(tm, "testSave.json", 5000, 10000);
            //d_test();
            IPAddress ipAddr = IPAddress.Loopback;
            IPEndPoint ipEndPoint = new(ipAddr, 12560);

            Socket sListener = new(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);
                while (true)
                {
                    Console.WriteLine($"Ожидаем соединение через порт {ipEndPoint}");
                    Socket socket = sListener.Accept();
                    Task taskSocket = new(Action, socket);
                    taskSocket.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Действия с клиентом
        /// </summary>
        /// <param name="obj_socket"></param>
        private static void Action(object obj_socket)
        {
            Socket socket = obj_socket as Socket;
            while (socket.Connected)
            {
                try
                {
                    byte[] bytes = new byte[10240];
                    int bytesRec = socket.Receive(bytes);
                    string json = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                    MountainResponse resp = new() { IsSuccess = false };
                    try
                    {
                        var request = JsonConvert.DeserializeObject<MountainReq>(json);
                        if (request != null)
                        {
                            resp.Key = request.Key;
                            Mountain mountain;
                            switch (request.Type)
                            {
                                case MountainRequestType.Get:
                                    if (_mountains.TryGetValue(resp.Key, out mountain))
                                    {
                                        resp.Mountain = mountain;
                                        resp.IsSuccess = true;
                                    }
                                    else
                                    {
                                        resp.ErrorMessage = "Ключ не найден";
                                    }
                                    break;

                                case MountainRequestType.Add:
                                    if (_mountains.ContainsKey(request.Key))
                                    {
                                        resp.ErrorMessage = "Ключ существует";
                                    }
                                    else
                                    {
                                        _mountains.AddOrUpdate(request.Key, request.Mountain, (s, mountain1) => request.Mountain);
                                        resp.IsSuccess = true;
                                    }
                                    break;

                                case MountainRequestType.Update:
                                    if (_mountains.ContainsKey(request.Key))
                                    {
                                        _mountains.AddOrUpdate(request.Key, request.Mountain, (s, mountain1) => request.Mountain);
                                        resp.IsSuccess = true;
                                    }
                                    else
                                    {
                                        resp.ErrorMessage = "Такого ключа не существует";
                                    }
                                    break;
                                case MountainRequestType.Remove:
                                    if (_mountains.ContainsKey(request.Key))
                                    {
                                        _mountains.TryRemove(request.Key, out mountain);
                                        resp.Mountain = mountain;
                                        resp.IsSuccess = true;
                                    }
                                    else
                                    {
                                        resp.ErrorMessage = "Указанного ключа не существует!";

                                    }
                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException();
                            }
                        }
                    }
                    catch (Exception exp)
                    {
                        resp.ErrorMessage = exp.Message;
                    }
                    Console.WriteLine("Полученный json: " + json);
                    // Отправляем ответ клиенту\
                    var jsonResponse = JsonConvert.SerializeObject(resp);
                    byte[] msg = Encoding.UTF8.GetBytes(jsonResponse);
                    Console.Write("Отправленный json: " + jsonResponse);
                    socket.Send(msg);
                }
                catch (Exception)
                {
                    break;
                }
            }
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        /// <summary>
        /// Подгрузка справочника из JSON файла
        /// </summary>
        private static void LoadMountains(string fileName)
        {
            using StreamReader jsonStreamReader = File.OpenText(fileName);
            JsonSerializer jsonSerializer = new();
            ConcurrentDictionary<string, Mountain> tempD = (ConcurrentDictionary<string, Mountain>)jsonSerializer.Deserialize(jsonStreamReader, typeof(ConcurrentDictionary<string, Mountain>));
            if (tempD != null)
            {
                _mountains = tempD;
            }
        }

        private static void AutoSave(object fileName)
        {
            if (_mountains!=null)
            {
                Console.WriteLine("StartAutoSave");
                using StreamWriter jsonStreamWriter = File.CreateText(fileName as string);
                JsonSerializer jsonSerializer = new();
                jsonSerializer.Serialize(jsonStreamWriter, _mountains);
            }
            else
            {
                Console.WriteLine("Отсутсвуют материалы в справочнике");
            }
        }

        static void add_test()
        {
            Mountain m = new()
            {
                Country = "Russian",
                Height = 2323,
                Title = "ЧТО-то там"
            };
            _mountains.TryAdd("1", m);

        }
    }
}