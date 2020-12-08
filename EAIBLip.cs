// Decompiled with JetBrains decompiler
// Type: EnableAllinteriors.EAIBLip
// Assembly: EnableAllinteriors, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3A85B110-A17E-4CA7-AD92-5E75D0146EEA
// Assembly location: C:\Users\Ekinoxx\Desktop\EnableAllinteriors.dll

using GTA;
using GTA.Math;

namespace EnableAllinteriors
{
  public class EAIBLip : Script
  {
    public Vector3 Pos { get; set; }

    public int BlipID { get; set; }

    public string name { get; set; }

    public bool Shortrange { get; set; }

    public EAIBLip() => base.\u002Ector();

    public EAIBLip(Vector3 p, int b, string n, bool s)
    {
      base.\u002Ector();
      this.Pos = p;
      this.BlipID = b;
      this.name = n;
      this.Shortrange = s;
    }
  }
}
