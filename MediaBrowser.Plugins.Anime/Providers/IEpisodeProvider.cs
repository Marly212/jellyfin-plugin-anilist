﻿using System.Threading;
using System.Threading.Tasks;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;

namespace MediaBrowser.Plugins.Anime.Providers
{
    public interface IEpisodeProvider
    {
        bool RequiresInternet { get; }
        bool NeedsRefreshBasedOnCompareDate(BaseItem item, BaseProviderInfo providerInfo);
        Task<EpisodeInfo> FindEpisodeInfo(Episode episode, string preferredMetadataLangauge, CancellationToken cancellationToken);
    }
}
