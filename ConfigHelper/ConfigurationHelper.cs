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

        // Semafore
        // Prevents reloading the file if it's modifyed by the program itself
        // Prevents Loading the file twice when externally modified since FileSystemWatcher calls twice
        private bool skip;

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
            skip = true;
        }

        private void FileWatch()
        {
            // Create a new FileSystemWatcher and set its properties.
            watcher = new FileSystemWatcher()
            {
                // Set the watch to look in that folder
                Path = ConfigDirectory,
                // Watch for changes (LastWrite)
                NotifyFilter = NotifyFilters.LastWrite,
                // Only watch config file.
                Filter = "*" + Path.GetFileName(ConfigPath),
            };

            // Add event handlers.
            watcher.Changed += Load;
            // Begin watching.
            watcher.EnableRaisingEvents = true;
        }

        private void Load(object source, FileSystemEventArgs e) 
        {
            if (skip)
            {
                skip = false;
                return;
            }
            skip = true;
            Load();
        }

        public void Load()
        {
            if (!File.Exists(ConfigPath))
            {
                Save();
            }

            //using var fileStream = File.Open(ConfigPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            //using var fileReader = new StreamReader(fileStream);
            //var data = fileReader.ReadToEnd();
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

            skip = true;

            File.WriteAllText(ConfigPath, JsonSerializer.Serialize(Config));
        }
    }
}
