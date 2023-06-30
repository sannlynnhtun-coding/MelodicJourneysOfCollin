using MelodicJourneysOfCollin.Models;

namespace MelodicJourneysOfCollin.Shared;

public partial class MainLayout
{
    private readonly string _youTubeLink = "https://www.youtube.com/@BurmaCollin";

    private MusicInfoModel _musicInfo;
    private EnumPageType _pageType = EnumPageType.Playlist;

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            Play(new MusicInfoModel
            {
                Artists = "Collin",
                Length = "00:36",
                Link = "Collin - Turn Up The Bass.mp3",
                Name = "Collin - Turn Up The Bass",
                Cover = "https://source.boomplaymusic.com/group10/M00/06/26/5d2d7165319643fc880643ac42d33a73.jpg",
            });
        }
    }

    private void Play(MusicInfoModel musicInfo)
    {
        _musicInfo = musicInfo;
        StateHasChanged();
    }

    private void OnChangeMenu(EnumPageType pageType)
    {
        _pageType = pageType;
        StateHasChanged();
    }
}