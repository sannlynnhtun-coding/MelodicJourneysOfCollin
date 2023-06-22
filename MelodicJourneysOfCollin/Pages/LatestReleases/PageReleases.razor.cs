using MelodicJourneysOfCollin.Models;
using MelodicJourneysOfCollin.Services;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components;
using System;
using System.Linq;

namespace MelodicJourneysOfCollin.Pages.LatestReleases
{
    public partial class PageReleases
    {
        private List<MusicInfoModel>? _musicInfoList;
        private List<MusicInfoModel>? _musicInfoListSlide1;
        private List<MusicInfoModel>? _musicInfoListSlide2;

        [Parameter]
        public EventCallback<MusicInfoModel> OnMusicSelection { get; set; }

        protected override void OnInitialized()
        {
            _musicInfoList = MusicService.LocalPlaylist;
            _musicInfoListSlide1 ??= new List<MusicInfoModel>();
            _musicInfoListSlide2 ??= new List<MusicInfoModel>();
            for (int i = 1; i <= _musicInfoList.Count; i++)
            {
                var item = _musicInfoList[i - 1];
                if (i % 2 != 0) _musicInfoListSlide1.Add(item);
                else _musicInfoListSlide2.Add(item);
            }
        }

        async Task Play(MusicInfoModel musicInfo)
        {
            await OnMusicSelection.InvokeAsync(musicInfo);
        }

        private ValueTask<ItemsProviderResult<MusicInfoModel>> GetLocalPlaylist(ItemsProviderRequest request)
        {
            return new(new ItemsProviderResult<MusicInfoModel>(
                _musicInfoListSlide1.Skip(request.StartIndex).Take(request.Count),
                _musicInfoListSlide1.Count));
        }

        void GoTo()
        {
            nav.NavigateTo("/");
        }
    }
}
