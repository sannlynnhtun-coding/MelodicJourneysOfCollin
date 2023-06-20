using MelodicJourneysOfCollin.Models;
using MelodicJourneysOfCollin.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web.Virtualization;

namespace MelodicJourneysOfCollin.Pages.Playlist.LocalPlaylist;

public partial class PageLocalPlaylist
{
    private List<MusicInfoModel>? _musicInfoList;

    [Parameter]
    public EventCallback<MusicInfoModel> OnMusicSelection { get; set; }

    protected override void OnInitialized()
    {
        _musicInfoList = MusicService.LocalPlaylist;
    }

    async Task Play(MusicInfoModel musicInfo)
    {
        await OnMusicSelection.InvokeAsync(musicInfo);
    }

    ValueTask<ItemsProviderResult<MusicInfoModel>> GetLocalPlaylist(ItemsProviderRequest request)
    {
        return new(new ItemsProviderResult<MusicInfoModel>(
            _musicInfoList.Skip(request.StartIndex).Take(request.Count),
            _musicInfoList.Count));
    }
}