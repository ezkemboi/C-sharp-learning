using System;

public static class CountChars 
{
  static void Main() {
    string str = "jacobjuma";
    char ch = 'j';
    countChars(str, ch);
  }
  static int countChars(string str, char ch) {
    int result = 0;
    for(int i = 0; i < str.Length; i++) {
      if(str[i] == ch) {
        result += 1;
      }
    }
    Console.WriteLine(result); // expect 2
    return result;
  }

}