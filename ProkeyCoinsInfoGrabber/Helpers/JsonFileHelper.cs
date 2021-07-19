﻿
using ProkeyCoinsInfoGrabber.Models;
using System;
using System.IO;
using System.Text.Json;

namespace ProkeyCoinsInfoGrabber.Helpers
{
    public static class JsonFileHelper<T>
    {        
        public static FunctionalityResult Create(string path, T instance)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            if (string.IsNullOrEmpty(path))
            {
                ConsoleUtiliy.LogError($"Path is empty! can not create file in empty path");
                return FunctionalityResult.Error;
            }
            if (instance == null)
            {
                ConsoleUtiliy.LogError($"Parameter is null!");
                return FunctionalityResult.Error;
            }
            try
            {
                //Configuration
                if (!File.Exists(path))
                {
                    using StreamWriter sw = new StreamWriter(path);
                    string appSettings_str = JsonSerializer.Serialize(instance, jsonSerializerOptions);
                    sw.Write(appSettings_str);
                }
                return FunctionalityResult.Succeed;

            }catch(IOException ioExp)
            {
                ConsoleUtiliy.LogError($"IOException: {ioExp.Message}");
                return FunctionalityResult.Exception;
            }
            catch(JsonException jsonExp)
            {
                ConsoleUtiliy.LogError($"JsonException: {jsonExp.Message}");
                return FunctionalityResult.Exception;
            }
            catch(Exception exp)
            {
                ConsoleUtiliy.LogError($"Exception: {exp.Message}");
                return FunctionalityResult.Exception;
            }

        }
    }
}
