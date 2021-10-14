
namespace ClassLibraryMountainPeaks
{
    /// <summary>
    /// Ответ из справочника вершин
    /// </summary>
    public class MountainResponse
    {
        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Признак успешного выполнения запроса
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// Ключ
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Информация о веришине горы
        /// </summary>
        public Mountain Mountain { get; set; }
    }
}
