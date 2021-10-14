namespace ClassLibraryMountainPeaks
{
    public class MountainReq
    {
        /// <summary>
        /// Тип запроса
        /// </summary>
        public MountainRequestType Type { get; set; }

        /// <summary>
        /// Ключ
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Информация о вершине
        /// </summary>
        public Mountain Mountain { get; set; }
    }
}
