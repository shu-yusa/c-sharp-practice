using System.Collections;
using System.Collections.Generic;

class ColorEnumerator : IEnumerator<string>
{
  string[] Colors;
  int Position = -1;

  public string Current // Current Generic
  {
    get { return Colors[Position]; }
  }

  object IEnumerator.Current // Current non-generic
  {
    get { return Colors[Position]; }
  }

  public bool MoveNext()
  {
    if (Position < Colors.Length - 1)
    {
      Position++;
      return true;
    }
    else 
      return false;
  }


  public void Reset()
  {
    Position = -1;
  }

  public void Dispose() {}

  public ColorEnumerator(string[] colors)
  {
    Colors = new string[colors.Length];
    for (int i=0; i<colors.Length; i++)
      Colors[i] = colors[i];
  }
}
