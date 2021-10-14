using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        Socket senderSocket = null;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // Буфер для входящих данных
            IPAddress iPAddress = IPAddress.Loopback;
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 12560);
            senderSocket = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            senderSocket.Connect(iPEndPoint);
        }

        private void buttonAddInfo_Click(object sender, EventArgs e)
        {
            AddOrUpdate(ClassLibraryMountainPeaks.MountainRequestType.Add);
        }

        private ClassLibraryMountainPeaks.MountainResponse SendReq(ClassLibraryMountainPeaks.MountainReq req)
        {
            byte[] bytes = new byte[10240];
            string jsonRequest = JsonConvert.SerializeObject(req);
            byte[] msg = Encoding.UTF8.GetBytes(jsonRequest);
            senderSocket.Send(msg);
            int bytesRec = senderSocket.Receive(bytes);
            string json = Encoding.UTF8.GetString(bytes, 0, bytesRec);
            ClassLibraryMountainPeaks.MountainResponse response = JsonConvert.DeserializeObject<ClassLibraryMountainPeaks.MountainResponse>(json);
            return response;
        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            senderSocket.Shutdown(SocketShutdown.Both);
            senderSocket.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            RemoveOrSearch(ClassLibraryMountainPeaks.MountainRequestType.Get);
        }

        private void AddOrUpdate(ClassLibraryMountainPeaks.MountainRequestType requestType)
        {
            ClassLibraryMountainPeaks.Mountain mountain = new ClassLibraryMountainPeaks.Mountain()
            {
                Country = textBoxCountry.Text,
                Height = Convert.ToInt32(numericUpDownHeight.Value),
                Title = textBoxTitle.Text
            };
            ClassLibraryMountainPeaks.MountainReq request = new ClassLibraryMountainPeaks.MountainReq()
            {
                Key = mountain.Title,
                Mountain = mountain,
                Type = requestType
            };
            ClassLibraryMountainPeaks.MountainResponse resp = SendReq(request);
            switch (resp.IsSuccess)
            {
                case false:
                    MessageBox.Show(resp.ErrorMessage);
                    break;
                case true:
                    MessageBox.Show("Действие успешно выполнено");
                    break;
            }
        }
        private void RemoveOrSearch(ClassLibraryMountainPeaks.MountainRequestType requestType)
        {
            string key = textBoxKey.Text;
            ClassLibraryMountainPeaks.MountainReq req = new ClassLibraryMountainPeaks.MountainReq()
            {
                Key = key,
                Type = requestType
            };
            ClassLibraryMountainPeaks.MountainResponse resp = SendReq(req);
            if (resp.Mountain == null)
                MessageBox.Show(resp.ErrorMessage);
            else
            {
                switch (requestType)
                {
                    case ClassLibraryMountainPeaks.MountainRequestType.Remove:
                        MessageBox.Show($"Элемент удален!!!\n\nНазвание: {resp.Mountain.Title}\n\nСтрана: {resp.Mountain.Country}\n\nВысота над уровнем моря: {resp.Mountain.Height}\n");
                        break;
                    case ClassLibraryMountainPeaks.MountainRequestType.Get:
                        MessageBox.Show($"Название: {resp.Mountain.Title}\n\nСтрана: {resp.Mountain.Country}\n\nВысота над уровнем моря: {resp.Mountain.Height}\n");
                        break;
                }
            }
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveOrSearch(ClassLibraryMountainPeaks.MountainRequestType.Remove);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            AddOrUpdate(ClassLibraryMountainPeaks.MountainRequestType.Update);
        }
    }
}
