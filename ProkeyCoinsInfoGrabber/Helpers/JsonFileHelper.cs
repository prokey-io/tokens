
using ProkeyCoinsInfoGrabber.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ProkeyCoinsInfoGrabber.Helpers
{
    public static class JsonFileHelper<T>
    {
        /// <summary>
        /// if file exist return success
        ///else Call CreateFile(Create Json file, serialize instance and write it to file)
        /// </summary>
        /// <param name="path"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static FunctionalityResult Create(string path, T instance)
        {
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
                if (!File.Exists(path))
                {
                    CreateFile(path, instance);
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

        /// <summary>
        /// Create Json file, serialize instance and write it to file
        /// </summary>
        /// <param name="path"></param>
        /// <param name="instance"></param>
        public static void CreateFile(string path, T instance)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            using StreamWriter sw = new StreamWriter(path);
            string appSettings_str = JsonSerializer.Serialize(instance, jsonSerializerOptions);
            sw.Write(appSettings_str);
        }

        /// <summary>
        /// if file exist return Failed
        /// else Call CreateFile(Create Json file, serialize instance and write it to file)
        /// </summary>
        /// <param name="path"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static FunctionalityResult CreateIfNotExist(string path, T instance)
        {
            
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
              
                if (!File.Exists(path))
                {
                    CreateFile(path, instance);
                }
                else
                {
                    ConsoleUtiliy.LogError($"{path} file already exists!");
                    return FunctionalityResult.Failed;
                }
                return FunctionalityResult.Succeed;

            }
            catch (IOException ioExp)
            {
                ConsoleUtiliy.LogError($"IOException: {ioExp.Message}");
                return FunctionalityResult.Exception;
            }
            catch (JsonException jsonExp)
            {
                ConsoleUtiliy.LogError($"JsonException: {jsonExp.Message}");
                return FunctionalityResult.Exception;
            }
            catch (Exception exp)
            {
                ConsoleUtiliy.LogError($"Exception: {exp.Message}");
                return FunctionalityResult.Exception;
            }

        }

        /// <summary>
        /// Deserialize json content of file to T type
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static T DeserializeFile(string filePath)
        {
            if(!File.Exists(filePath))
            {
                ConsoleUtiliy.LogError($"Json file not found!: {filePath}");
                return default;
            }
            try
            {
                string fileContent = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(fileContent);
            }
            catch (IOException ioExp)
            {
                ConsoleUtiliy.LogError($"IOException in {filePath}: {ioExp.Message}");
                return default;
            }
            catch (JsonException jsonExp)
            {
                ConsoleUtiliy.LogError($"JsonException in {filePath}: {jsonExp.Message}");
                return default;
            }
            catch (Exception exp)
            {
                ConsoleUtiliy.LogError($"Exception in {filePath}: {exp.Message}");
                return default;
            }
        }

        /// <summary>
        /// Store tokens/coins in json files
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public static FunctionalityResult StoreTokensInFile(List<T> tokens, string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                foreach (T token in tokens)
                {
                    string filePath = string.Empty;
                    switch (token)
                    {
                        case ERC20Token erc20Token:
                            filePath = Path.Combine(directoryPath, erc20Token.address+".json");
                            break;

                        default:
                            break;
                    }
                    if(string.IsNullOrEmpty(filePath))
                    {
                        ConsoleUtiliy.LogError($"File name can not be null!");
                        return FunctionalityResult.Failed;
                    }

                    FunctionalityResult initFileResult = JsonFileHelper<T>.CreateIfNotExist(filePath, token);
                    if (initFileResult != FunctionalityResult.Succeed)
                    {
                        return initFileResult;
                    }
                }
                return FunctionalityResult.Succeed;
            }
            else
            {
                ConsoleUtiliy.LogError($"{directoryPath} directory path not found!");
                return FunctionalityResult.NotFound;
            }
        }

    }
}
