namespace GameBananaAPI
{
    public static class APIPaths
    {
        public const string BaseImageUrl = "https://images.gamebanana.com/img/ss/mods/";
        public const string BaseGameUrl = "https://gamebanana.com/apiv11/Game/";
        public const string BaseDownloadUrl = "https://gamebanana.com/dl/";
        public const string ModProfileUrl = "https://gamebanana.com/apiv11/Mod/";

        public static string GetModProfileUrl(int modId) => ModProfileUrl + modId + "/ProfilePage";
    }
}
