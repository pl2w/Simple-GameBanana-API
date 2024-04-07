namespace GameBananaAPI.Data
{
    public class FileData
    {
        public int _idRow { get; set; }
        public string _sFile { get; set; }
        public int _nFilesize { get; set; }
        public string _sDescription { get; set; }
        public int _tsDateAdded { get; set; }
        public int _nDownloadCount { get; set; }
        public string _sAnalysisState { get; set; }
        public string _sDownloadUrl { get; set; }
        public string _sMd5Checksum { get; set; }
        public string _sClamAvResult { get; set; }
        public string _sAvastAvResult { get; set; }
        public string _sAnalysisResult { get; set; }
        public bool _bContainsExe { get; set; }
    }
}
