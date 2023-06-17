using MelodicJourneysOfCollin.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MelodicJourneysOfCollin.Services
{
    public static class MusicService
    {
        public static string ToLocalLink(this string str)
        {
            return $"music/{str}";
        }
        
        public static List<MusicInfoModel> SoundCloundPlaylist =>
                                    GetMusicPlayList<MusicInfoModel>(JsonData.MusicList)
                                     .Where(x => x.PlatformType == (int)EnumMusicPlatformType.SoundCloud)
                                     .ToList();
        public static List<YouTubePlaylistModel> YouTubePlaylist =>
                                     GetMusicPlayList<YouTubePlaylistModel>(JsonData.MusicList)
                                     .Where(x => x.PlatformType == (int)EnumMusicPlatformType.YouTube)
                                     .ToList();
        public static List<MediaFireDownloadModel> MediaFireDownloadlist =>
                                     GetMusicPlayList<MediaFireDownloadModel>(JsonData.MusicList)
                                     .Where(x => x.PlatformType == (int)EnumMusicPlatformType.MediaFire)
                                     .ToList();
        public static List<KrakenFilesPlaylistModel> KrakenFilesPlaylist =>
                                     GetMusicPlayList<KrakenFilesPlaylistModel>(JsonData.MusicList)
                                     .Where(x => x.PlatformType == (int)EnumMusicPlatformType.KrakenFiles)
                                     .ToList();
        //public static List<FavoriteSongListModel> FavoriteSongList =>
        //                             GetMusicPlayList<FavoriteSongListModel>(JsonData.MusicList)
        //                             .Where(x => x.PlatformType == (int)EnumMusicPlatformType.KrakenFiles)
        //                             .ToList();
        public static List<T> GetMusicPlayList<T>(string json)
        {
            //var list = JsonConvert.DeserializeObject<List<T>>(json);
            var list = json.ToObject<List<T>>();
            return list;
        }
    }

    public static class JsonData
    {
        public static string MusicList { get; } = @"[
        {
            ""Id"": ""1"",
            ""Name"": ""Collin - Day 4 [2023]"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""2"",
            ""Name"": ""Collin - Day 4 [2023]"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""3"",
            ""Name"": ""Collin - Day 4 [2023]"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""4"",
            ""Name"": ""Collin - Day 4 [2023]"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://krakenfiles.com/embed-audio/pj1IbfvEYt?autoplay=false"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""5"",
            ""Name"": ""Collin - Day 4 [2023]"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/4yztavq6mvvf4ml/Collin_-_ID_%2528A_Moment_to_Remember%2529_%2528Original_Mix%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""6"",
            ""Name"": ""Collin - Day 3 [2023]"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""7"",
            ""Name"": ""Collin - Day 3 [2023]"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""8"",
            ""Name"": ""Collin - Day 3 [2023]"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1492769980&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""9"",
            ""Name"": ""Collin - Day 3 [2023]"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://krakenfiles.com/embed-audio/vUAoqDJ3oM?autoplay=false"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""10"",
            ""Name"": ""Collin - Day 3 [2023]"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/q89ri4m9rgwq5ug/Collin_-_ID_%2528I_miss_you_so_bad_in_Thingyan%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""11"",
            ""Name"": ""Collin - Day 2 [2023]"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""12"",
            ""Name"": ""Collin - Day 2 [2023]"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""13"",
            ""Name"": ""Collin - Day 2 [2023]"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1492252795&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""14"",
            ""Name"": ""Collin - Day 2 [2023]"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://krakenfiles.com/embed-audio/kN3n4mraBw?autoplay=false"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""15"",
            ""Name"": ""Collin - Day 2 [2023]"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/q89ri4m9rgwq5ug/Collin_-_ID_%2528I_miss_you_so_bad_in_Thingyan%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""16"",
            ""Name"": ""Collin - Day 1 [2023]"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""17"",
            ""Name"": ""Collin - Day 1 [2023]"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""18"",
            ""Name"": ""Collin - Day 1 [2023]"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1491539662&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""19"",
            ""Name"": ""Collin - Day 1 [2023]"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://krakenfiles.com/embed-audio/YWxiONZDKJ?autoplay=false"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""20"",
            ""Name"": ""Collin - Day 1 [2023]"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/t1zvgav5ke6rg02/Collin_-_ID_%2528Love%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""21"",
            ""Name"": ""The Kid Laroi, Justin Bieber - Stay (Collin Remix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""22"",
            ""Name"": ""The Kid Laroi, Justin Bieber - Stay (Collin Remix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""23"",
            ""Name"": ""The Kid Laroi, Justin Bieber - Stay (Collin Remix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1251260947&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""24"",
            ""Name"": ""The Kid Laroi, Justin Bieber - Stay (Collin Remix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://krakenfiles.com/embed-audio/DmNztyV7BO?autoplay=false"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""25"",
            ""Name"": ""The Kid Laroi, Justin Bieber - Stay (Collin Remix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/t1zvgav5ke6rg02/Collin_-_ID_%2528Love%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""26"",
            ""Name"": ""Marshmello x Jonas Brothers - Leave Before You Love Me (Collin Edit)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""27"",
            ""Name"": ""Marshmello x Jonas Brothers - Leave Before You Love Me (Collin Edit)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""28"",
            ""Name"": ""Marshmello x Jonas Brothers - Leave Before You Love Me (Collin Edit)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1250376910&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""29"",
            ""Name"": ""Marshmello x Jonas Brothers - Leave Before You Love Me (Collin Edit)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://krakenfiles.com/embed-audio/4SVs8nq8ju?autoplay=false"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""30"",
            ""Name"": ""Marshmello x Jonas Brothers - Leave Before You Love Me (Collin Edit)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/t1zvgav5ke6rg02/Collin_-_ID_%2528Love%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""31"",
            ""Name"": ""Collin - ID (Love)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""32"",
            ""Name"": ""Collin - ID (Love)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""33"",
            ""Name"": ""Collin - ID (Love)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1249855954&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""34"",
            ""Name"": ""Collin - ID (Love)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://krakenfiles.com/embed-audio/J6FI7wws6g?autoplay=false"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""35"",
            ""Name"": ""Collin - ID (Love)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/t1zvgav5ke6rg02/Collin_-_ID_%2528Love%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""36"",
            ""Name"": ""Collin - ID (I miss you so bad in Thingyan)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""37"",
            ""Name"": ""Collin - ID (I miss you so bad in Thingyan)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""38"",
            ""Name"": ""Collin - ID (I miss you so bad in Thingyan)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1249500820&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""39"",
            ""Name"": ""Collin - ID (I miss you so bad in Thingyan)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://krakenfiles.com/embed-audio/7JJUCwjnEc?autoplay=false"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""40"",
            ""Name"": ""Collin - ID (I miss you so bad in Thingyan)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/yiw2g698pdiwhom/Collin_-_Switch_Back_%2528Original_Mix%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""41"",
            ""Name"": ""Collin - Memories (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""42"",
            ""Name"": ""Collin - Memories (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""43"",
            ""Name"": ""Collin - Memories (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1133265088&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""44"",
            ""Name"": ""Collin - Memories (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://krakenfiles.com/embed-audio/sNTWUdvPkw?autoplay=false"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""45"",
            ""Name"": ""Collin - Memories (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/yiw2g698pdiwhom/Collin_-_Switch_Back_%2528Original_Mix%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""46"",
            ""Name"": ""Blasterjaxx - Legion (Collin Remix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""47"",
            ""Name"": ""Blasterjaxx - Legion (Collin Remix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""48"",
            ""Name"": ""Blasterjaxx - Legion (Collin Remix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1131042931&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""49"",
            ""Name"": ""Blasterjaxx - Legion (Collin Remix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""50"",
            ""Name"": ""Blasterjaxx - Legion (Collin Remix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/pqqrhje7kzz301k/Colllin_-_Invisible_%2528Original_Mix%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""51"",
            ""Name"": ""The Kid Laroi, Justin Bieber - Stay (Collin Remix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""52"",
            ""Name"": ""The Kid Laroi, Justin Bieber - Stay (Collin Remix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""53"",
            ""Name"": ""The Kid Laroi, Justin Bieber - Stay (Collin Remix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1130896885&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""54"",
            ""Name"": ""The Kid Laroi, Justin Bieber - Stay (Collin Remix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""55"",
            ""Name"": ""The Kid Laroi, Justin Bieber - Stay (Collin Remix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/yxlp0s65qplazun/Colllin_-_Nobody_Gets_Out_Alive_%2528Original_Mix%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""56"",
            ""Name"": ""Sagemode vs Collin - Sky Cracker (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""57"",
            ""Name"": ""Sagemode vs Collin - Sky Cracker (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""58"",
            ""Name"": ""Sagemode vs Collin - Sky Cracker (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/937052296&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""59"",
            ""Name"": ""Sagemode vs Collin - Sky Cracker (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""60"",
            ""Name"": ""Sagemode vs Collin - Sky Cracker (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/zg1natm8cs7df8z/David_Guetta_%2526_Bebe_Rexha_-_I%2527m_Good_%2528Collin_Festival_Mix%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""61"",
            ""Name"": ""Collin - Switch Back (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""62"",
            ""Name"": ""Collin - Switch Back (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""63"",
            ""Name"": ""Collin - Switch Back (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/657102830&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""64"",
            ""Name"": ""Collin - Switch Back (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""65"",
            ""Name"": ""Collin - Switch Back (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/zg1natm8cs7df8z/David_Guetta_%2526_Bebe_Rexha_-_I%2527m_Good_%2528Collin_Festival_Mix%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""66"",
            ""Name"": ""Collin - Father's Love (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""67"",
            ""Name"": ""Collin - Father's Love (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""68"",
            ""Name"": ""Collin - Father's Love (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/657101390&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""69"",
            ""Name"": ""Collin - Father's Love (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""70"",
            ""Name"": ""Collin - Father's Love (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/e7t9rfdaqc4d7g1/I%2527m_Good_%2528Blue%2529_Collin_Remix.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""71"",
            ""Name"": ""Collin - Last Life (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""72"",
            ""Name"": ""Collin - Last Life (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""73"",
            ""Name"": ""Collin - Last Life (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/657090707&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""74"",
            ""Name"": ""Collin - Last Life (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""75"",
            ""Name"": ""Collin - Last Life (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/jxacvg42jv37ugx/Justin_Bieber_-_Ghost_%2528Collin_Remix%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""76"",
            ""Name"": ""Collin - Invisible (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""77"",
            ""Name"": ""Collin - Invisible (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""78"",
            ""Name"": ""Collin - Invisible (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/657088022&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""79"",
            ""Name"": ""Collin - Invisible (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""80"",
            ""Name"": ""Collin - Invisible (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/t9m97qtdaoa9we7/K3V%2521N_%2526_Collin_-_Sign_Of_Love_%2528Original_Mix%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""81"",
            ""Name"": ""Sage & Collin - The Sage (VIP Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""82"",
            ""Name"": ""Sage & Collin - The Sage (VIP Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""83"",
            ""Name"": ""Sage & Collin - The Sage (VIP Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/433934946&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""84"",
            ""Name"": ""Sage & Collin - The Sage (VIP Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""85"",
            ""Name"": ""Sage & Collin - The Sage (VIP Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/gxyxqhzo9datyxo/Kavin_%2526_Colllin_-_Melody_Of_Angels_%2528Original_Mix%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""86"",
            ""Name"": ""K3/\\!N & Collin - Sign Of Love (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""87"",
            ""Name"": ""K3/\\!N & Collin - Sign Of Love (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""88"",
            ""Name"": ""K3/\\!N & Collin - Sign Of Love (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/421370907&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""89"",
            ""Name"": ""K3/\\!N & Collin - Sign Of Love (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""90"",
            ""Name"": ""K3/\\!N & Collin - Sign Of Love (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/dhpuqw5hugl35e7/SageMode_x_Collin_-_Sky_Cracker_%2528Original_Mix%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""91"",
            ""Name"": ""Thingyan Moe (The Luminosity x Colllin)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""92"",
            ""Name"": ""Thingyan Moe (The Luminosity x Colllin)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""93"",
            ""Name"": ""Thingyan Moe (The Luminosity x Colllin)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/421368231&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""94"",
            ""Name"": ""Thingyan Moe (The Luminosity x Colllin)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""95"",
            ""Name"": ""Thingyan Moe (The Luminosity x Colllin)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/0slafv2r1efnl0f/The_Huftgold_x_Colllin_-_Aparchie_%2528Original_Mix%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""96"",
            ""Name"": ""Sage x Collin - Imaginations (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""97"",
            ""Name"": ""Sage x Collin - Imaginations (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""98"",
            ""Name"": ""Sage x Collin - Imaginations (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/421319970&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""99"",
            ""Name"": ""Sage x Collin - Imaginations (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""100"",
            ""Name"": ""Sage x Collin - Imaginations (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://www.mediafire.com/file/6c525a4es9z1g2g/The_Kid_Laroi%252C_Justin_Bieber_-_Stay_%2528Collin_Remix%2529.mp3/file"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""101"",
            ""Name"": ""Collin - Nobody Gets Out Alive (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""102"",
            ""Name"": ""Collin - Nobody Gets Out Alive (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""103"",
            ""Name"": ""Collin - Nobody Gets Out Alive (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/421317885&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""104"",
            ""Name"": ""Collin - Nobody Gets Out Alive (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""105"",
            ""Name"": ""Collin - Nobody Gets Out Alive (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""106"",
            ""Name"": ""Collin - Senses (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""107"",
            ""Name"": ""Collin - Senses (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""108"",
            ""Name"": ""Collin - Senses (Original Mix)"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/421316241&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""109"",
            ""Name"": ""Collin - Senses (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""110"",
            ""Name"": ""Collin - Senses (Original Mix)"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""111"",
            ""Name"": ""Electric Twinz (P2 x Collin) - K.O.T.E.M.F (Original Mix) Free Download"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""112"",
            ""Name"": ""Electric Twinz (P2 x Collin) - K.O.T.E.M.F (Original Mix) Free Download"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""113"",
            ""Name"": ""Electric Twinz (P2 x Collin) - K.O.T.E.M.F (Original Mix) Free Download"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/346994513&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""114"",
            ""Name"": ""Electric Twinz (P2 x Collin) - K.O.T.E.M.F (Original Mix) Free Download"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""115"",
            ""Name"": ""Electric Twinz (P2 x Collin) - K.O.T.E.M.F (Original Mix) Free Download"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""4""
        },
        {
            ""Id"": ""116"",
            ""Name"": ""Kavin & Colllin - Melody Of Angels (Original Mix) Free Download"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""0""
        },
        {
            ""Id"": ""117"",
            ""Name"": ""Kavin & Colllin - Melody Of Angels (Original Mix) Free Download"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""1""
        },
        {
            ""Id"": ""118"",
            ""Name"": ""Kavin & Colllin - Melody Of Angels (Original Mix) Free Download"",
            ""Genre"": ""EDM"",
            ""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/326008815&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""2""
        },
        {
            ""Id"": ""119"",
            ""Name"": ""Kavin & Colllin - Melody Of Angels (Original Mix) Free Download"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""3""
        },
        {
            ""Id"": ""120"",
            ""Name"": ""Kavin & Colllin - Melody Of Angels (Original Mix) Free Download"",
            ""Genre"": ""EDM"",
""Link"": ""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/1493379526&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true"",
            ""PlatformType"": ""4""
        }
    ]";
    }
}
