using System;
using System.Collections.Generic;
using Jellyfin.Plugin.UserPasswordReset.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.UserPasswordReset
{
    /// <summary>
    /// Jellyfin plugin that provides a configuration page.
    /// </summary>
    public sealed class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Plugin"/> class.
        /// </summary>
        /// <param name="applicationPaths">Application paths.</param>
        /// <param name="xmlSerializer">XML serializer.</param>
        public Plugin(
            IApplicationPaths applicationPaths,
            IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
        {
        }

        /// <inheritdoc />
        public override string Name => "User Password Reset";

        /// <inheritdoc />
        public override string Description =>
            "Provides an admin configuration page.";

        /// <inheritdoc />
        public override Guid Id =>
            Guid.Parse("d8c01d3b-9b3f-4f4c-a0f3-8d3a7a8b4c11");

        /// <inheritdoc />
        public IEnumerable<PluginPageInfo> GetPages()
        {
            return new[]
            {
                new PluginPageInfo
                {
                    Name = "User Password Reset",
                    EmbeddedResourcePath =
                        "Jellyfin.Plugin.UserPasswordReset.Configuration.configPage.html"
                }
            };
        }
    }
}
