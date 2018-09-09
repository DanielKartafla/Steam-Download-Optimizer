using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamDownloadLibrary
{
  public class Feature
  {
    private int m_CategoryLevel;
    private int m_FeatureId;
    private string m_Name;

    public int CategoryLevel
    {
      get { return m_CategoryLevel; }
      set { m_CategoryLevel = value; }
    }

    public int FeatureId
    {
      get { return m_FeatureId; }
      set { m_FeatureId = value; }
    }

    public string Name
    {
      get { return m_Name; }
      set { m_Name = value; }
    }

    public Feature(int categoryLevel, int featureId)
    {
      this.CategoryLevel = categoryLevel;
      this.FeatureId = featureId;
    }

    public Feature(int categoryLevel, int featureId, string name)
    {
      this.CategoryLevel = categoryLevel;
      this.FeatureId = featureId;
      this.Name = name;
    }
  }
}
