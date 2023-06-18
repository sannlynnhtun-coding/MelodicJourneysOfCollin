namespace MelodicJourneysOfCollin.Models
{
    public class SoundCloudPaginationModel
    {
        public List<SoundCloudPlaylistModel> musicList { get; set; } = new List<SoundCloudPlaylistModel>();
        public int currentPage { get; set; }
        public int totalPage { get; set; }
    }
}
