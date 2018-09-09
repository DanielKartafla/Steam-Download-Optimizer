using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SteamDownloadLibrary
{
  public class GameLibrary
  {
    private static GameLibrary m_Instance;
    private static readonly object padlock = new object();

    public static GameLibrary Instance
    {
      get
      {
        lock (padlock)
        {
          if (m_Instance == null)
          {
            m_Instance = new GameLibrary();
          }
          return m_Instance;
        }
      }
    }

    private string m_SteamappsPath;

    public string SteamappsPath
    {
      get { return m_SteamappsPath; }
      private set
      {
        m_SteamappsPath = value; 
        LoadLibrary();
      }
    }

    public List<Game> GameList { get; private set; }

    private GameLibrary()
    {
      GameList = new List<Game>();

    }

    public void Initialize(string steamappsPath)
    {
      SteamappsPath = steamappsPath;
    }

    private void LoadLibrary()
    {
      Regex regex = new Regex(@".*appmanifest_([0-9]*)\.acf", RegexOptions.Compiled, TimeSpan.FromSeconds(5));

      foreach (string appmanifest in Directory.GetFiles(SteamappsPath, "*.acf", SearchOption.TopDirectoryOnly))
      {
        GameList.Add(new Game(Convert.ToInt32(regex.Matches(appmanifest)[0].Groups[1].Captures[0].Value)));
      }
    }
  }
}
