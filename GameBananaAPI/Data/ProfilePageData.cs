using System.Collections.Generic;

namespace GameBananaAPI.Data
{
    public class ProfilePageData
    {
        public int _idRow { get; set; }
        public string _nStatus { get; set; }
        public bool _bIsPrivate { get; set; }
        public int _tsDateModified { get; set; }
        public int _tsDateAdded { get; set; }
        public string _sProfileUrl { get; set; }
        public MediaData _aPreviewMedia { get; set; }
        public bool _bIsFlagged { get; set; }
        public string _sCommentsMode { get; set; }
        public bool _bAccessorIsSubmitter { get; set; }
        public bool _bIsTrashed { get; set; }
        public bool _bIsWithheld { get; set; }
        public string _sName { get; set; }
        public int _nUpdatesCount { get; set; }
        public bool _bHasUpdates { get; set; }
        public int _tsDateUpdated { get; set; }
        public int _nAllTodosCount { get; set; }
        public bool _bHasTodos { get; set; }
        public int _nPostCount { get; set; }
        //public AttributesData _aAttributes { get; set; }
        // tags
        public bool _bCreatedBySubmitter { get; set; }
        public bool _bIsPorted { get; set; }
        public int _nThanksCount { get; set; }
        // content ratings
        public string _sInitialVisibility { get; set; }
        public string _sDownloadUrl { get; set; }
        public int _nDownloadCount { get; set; }
        public List<FileData> _aFiles { get; set; }
        public int _nSubscriberCount { get; set; }
        // contributing studios
        public string _sLicense { get; set; }
        // licensce checklist
        public string _sDescription { get; set; }
        public bool _bGenerateTableOfContents { get; set; }
        public string _sText { get; set; }
        public bool _bIsObsolete { get; set; }
        public int _nLikeCount { get; set; }
        public int _nViewCount { get; set; }
        public string _sVersion { get; set; }
        public List<(string, string)> _aRequirements { get; set; }
    }
}
