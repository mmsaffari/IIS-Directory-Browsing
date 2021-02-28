﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace MMS.BetterDirectoryListing {
	/// <summary>
	/// 
	/// </summary>
	public class DirectoryBrowsingModuleConfigurationSection : ConfigurationSection {
		public const bool DefaultEnabled = true;
		public const string ConfigurationSectionName = "directoryBrowsing";

		private static ConfigurationPropertyCollection _properties = new ConfigurationPropertyCollection();
		private static readonly ConfigurationProperty _propEnabled = new ConfigurationProperty("enabled", typeof(bool), true);
		private static readonly ConfigurationProperty _propHideSensitiveFiles = new ConfigurationProperty("hideSensitiveFiles", typeof(bool), true);

		static DirectoryBrowsingModuleConfigurationSection() {
			_properties.Add(_propEnabled);
			_properties.Add(_propHideSensitiveFiles);
		}

		protected override ConfigurationPropertyCollection Properties => _properties;

		[ConfigurationProperty("enabled", DefaultValue = true)]
		public bool Enabled {
			get => (bool)base[_propEnabled];
			set => base[_propEnabled] = value;
		}

		[ConfigurationProperty("hideSensitiveFiles", DefaultValue = true)]
		public bool HideSensitiveFiles {
			get => (bool)base[_propHideSensitiveFiles];
			set => base[_propHideSensitiveFiles] = value;
		}
	}
}