int count_word_string(string s="aabbabc", char word='a')
{
    int count = 0;
    foreach (char i in s)
    {
        if (i == word)
        {
            count++;
        }
    }
    return count;
}


Console.WriteLine(count_word_string());