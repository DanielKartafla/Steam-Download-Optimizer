using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamDownloadLibrary
{
  public class Game
  {
    private string m_Name;
    private int m_AppId;
    private List<Feature> m_Features;
    private int m_UpdateBehavior;

    public string Name
    {
      get { return m_Name; }
      private set { m_Name = value; }
    }

    public int AppId
    {
      get { return m_AppId; }
      set
      {
        m_AppId = value;
        LookUpName();
        LookUpFeatures();
      }
    }
    
    public List<Feature> Features
    {
      get { return m_Features; }
      set { m_Features = value; }
    }
    
    public int UpdateBehavior
    {
      get { return m_UpdateBehavior; }
      set { m_UpdateBehavior = value; }
    }

    public Game(int appId)
    {
      Features = new List<Feature>();
      AppId = appId;
      UpdateBehavior = 0;
    }

    private void LookUpName()
    {
      //TODO: Look up real name
      Name = "Steam Game Foo";
    }

    private void LookUpFeatures()
    {
      //TODO: Look up real features
      Features.Clear();
      Features.Add(new Feature(2, 1, "Multi-player"));
      Features.Add(new Feature(2, 2, "Single-player"));
    }
  }
}
