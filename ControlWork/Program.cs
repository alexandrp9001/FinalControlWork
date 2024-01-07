string[] arr = { "KVM", "26", "Kazantip", "ABB", "6" };

string[] numSing(string[] arr)
{
  int n = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length <= 3)
      n++;
  }
  string[] result = new string[n];
  int j = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length <= 3)
    {
      result[j] = arr[i];
      j++;
    }
  }
  return result;
}