using System.Collections.Generic;

namespace GameBananaAPI
{
    public class RecordData
    {
        public int _idRow { get; set; }
        public string _sModelName { get; set; }
        public string _sSingularTitle { get; set; }
        public string _sIconClasses { get; set; }
        public string _sName { get; set; }
        public string _sProfileUrl { get; set; }
        public int _tsDateAdded { get; set; }
        public int _tsDateModified { get; set; }
        public bool _bHasFiles { get; set; }
        public List<string> _aTags { get; set; }
        public MediaData _aPreviewMedia { get; set; }
        public SubmitterData _aSubmitter { get; set; }
        public CategoryData _aRootCategory { get; set; }
        public string _akDifficultyLevel { get; set; }
        public string _sDifficultyLevel { get; set; }
        public bool _bIsObsolete { get; set; }
        public string _sInitialVisibility { get; set; }
        public bool _bHasContentRatings { get; set; }
        public bool _bWasFeatured { get; set; }
        public int _nViewCount { get; set; }
        public bool _bIsOwnedByAccesor { get; set; }
    }
}
