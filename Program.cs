namespace AdventOfCode_2023_01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			StreamReader reader;
			using (reader = new StreamReader("input.txt"))
			{
				string input;
				char digit1='7';
				char digit2='7';
				while ((input = reader.ReadLine()) != null)
				{
					//First Digit
					for (int i = 0; i < input.Length; i++) // First Digit
					{
						if (char.IsDigit(input[i]))
						{
							digit1 = input[i];
							break;
						}
						else //Digits with words
						{
							char c = input[i];
							if (c == 'o' && i + 2 < input.Length)
							{
								if (input[i + 1] == 'n' && input[i + 2] == 'e')
								{
									digit1 = '1';
									break;
								}
							}
							if (c == 't' && i + 2 < input.Length)
							{
								if (input[i + 1] == 'w' && input[i + 2] == 'o')
								{
									digit1 = '2';
									break;
								}
							}
							if (c == 't' && i + 4 < input.Length)
							{
								if (input[i + 1] == 'h' && input[i + 2] == 'r' && input[i + 3] == 'e' && input[i + 4] == 'e')
								{
									digit1 = '3';
									break;
								}
							}
							if (c == 'f' && i + 3 < input.Length)
							{
								if (input[i + 1] == 'o' && input[i + 2] == 'u' && input[i + 3] == 'r')
								{
									digit1 = '4';
									break;
								}
							}
							if (c == 'f' && i + 3 < input.Length)
							{
								if (input[i + 1] == 'i' && input[i + 2] == 'v' && input[i + 3] == 'e')
								{
									digit1 = '5';
									break;
								}
							}
							if (c == 's' && i + 2 < input.Length)
							{
								if (input[i + 1] == 'i' && input[i + 2] == 'x')
								{
									digit1 = '6';
									break;
								}
							}
							if (c == 's' && i + 4 < input.Length)
							{
								if (input[i + 1] == 'e' && input[i + 2] == 'v' && input[i + 3] == 'e' && input[i + 4] == 'n')
								{
									digit1 = '7';
									break;
								}
							}
							if (c == 'e' && i + 4 < input.Length)
							{
								if (input[i + 1] == 'i' && input[i + 2] == 'g' && input[i + 3] == 'h' && input[i + 4] == 't')
								{
									digit1 = '8';
									break;
								}
							}
							if (c == 'n' && i + 3 < input.Length)
							{
								if (input[i + 1] == 'i' && input[i + 2] == 'n' && input[i + 3] == 'e')
								{
									digit1 = '9';
									break;
								}
							}
							if (c == 'z' && i + 3 < input.Length)
							{
								if (input[i + 1] == 'e' && input[i + 2] == 'r' && input[i + 3] == 'o')
								{
									digit1 = '3';
									break;
								}
							}
						}
					}

					//Second Digit
					for (int i = input.Length-1; i >= 0; i--) 
					{
						if (char.IsDigit(input[i]))
						{
							digit2 = input[i];
							break;
						}
						else
						{
							if(i + 2 < input.Length) 
							{
								string digit = input.Substring(i, 3);
								if (digit == "one") 
								{
									digit2 = '1';
									break;
								}
								else if (digit == "two")
								{
									digit2 = '2';
									break;
								}
								else if (digit == "six")
								{
									digit2 = '6';
									break;
								}
							}
							if (i + 3 < input.Length)
							{
								string digit = input.Substring(i, 4);
								if (digit == "four")
								{
									digit2 = '4';
									break;
								}
								else if (digit == "five")
								{
									digit2 = '5';
									break;
								}
								else if (digit == "nine")
								{
									digit2 = '9';
									break;
								}
								else if (digit == "zero")
								{
									digit2 = '0';
									break;
								}
							}
							if (i + 4 < input.Length)
							{
								string digit = input.Substring(i, 5);
								if (digit == "three")
								{
									digit2 = '3';
									break;
								}
								else if (digit == "seven")
								{
									digit2 = '7';
									break;
								}
								else if (digit == "eight")
								{
									digit2 = '8';
									break;
								}
							}
						}
					}
					char[] chars = new char[] {digit1, digit2};
                    string output = new string(chars);
                    Console.WriteLine(output);
                    int number = int.Parse(output);
					sum += number;
				}
				Console.WriteLine(sum);

			}

		}
	}
}