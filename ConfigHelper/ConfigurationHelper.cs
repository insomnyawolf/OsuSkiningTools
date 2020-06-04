using System;
using System.IO;
using System.Text.Json;

namespace ConfigHelper
{
    public class ConfigurationHelper<T> where T : new()
    {
        private readonly string ConfigPath;
        private readonly string ConfigDirectory;
        private FileSystemWatcher watcher;
        public T Config { get; private set; }

        public ConfigurationHelper(string ConfigPath)
        {
            if (string.IsNullOrEmpty(ConfigPath))
            {
                throw new Exception($"{nameof(ConfigPath)} can not be null or empty.");
            }
            this.ConfigPath = ConfigPath;
            ConfigDirectory = Path.GetDirectoryName(ConfigPath);

            Load();
            FileWatch();
        }

        private void FileWatch()
        {
            // Create a new FileSystemWatcher and set its properties.
            watcher = new FileSystemWatcher();
            watcher.Path = ConfigDirectory;

            // Watch for changes in LastAccess and LastWrite times, and
            // the renaming of files or directories.
            watcher.NotifyFilter = NotifyFilters.LastWrite;

            // Only watch text files.
            watcher.Filter = "*" + Path.GetFileName(ConfigPath);

            // Add event handlers.
            watcher.Changed += Load;

            // Begin watching.
            watcher.EnableRaisingEvents = true;
        }

        private void Load(object source, FileSystemEventArgs e) => Load();
        public void Load()
        {
            if (!File.Exists(ConfigPath))
            {
                Save();
            }
            Config = JsonSerializer.Deserialize<T>(File.ReadAllText(ConfigPath));
        }

        public void Save()
        {
            if (Config is null)
            {
                Config = new T();
            }

            if (!Directory.Exists(ConfigDirectory))
            {
                Directory.CreateDirectory(ConfigDirectory);
            }

            File.WriteAllText(ConfigPath, JsonSerializer.Serialize(Config));
        }
    }
}
