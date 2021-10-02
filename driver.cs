using System;
using System.Collections;

class PlayingCard {
  private string suite;
  private string val;

  public PlayingCard(string s, string v)
  {
    Suite = s;
    Val = v;
  }
  string Suite
  {
    get{return suite;}
    set{suite = value;}
  }
  string Val
  {
    get{return val;}
    set{val = value;}
  }
  public override string ToString()
  {
    return (Val + " of "+ Suite);
  }
}
