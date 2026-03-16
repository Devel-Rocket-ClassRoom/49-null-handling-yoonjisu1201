using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.
var numbers = new List<int>();

// 여러 요소 한 번에 추가
numbers.AddRange(new[] { 10, 20, 30, 40});
Console.WriteLine($"추가 후: {string.Join(", ", numbers)}");

// 특정 위치에 삽입
numbers.Insert(0, 5);     // 맨 앞에 5 삽입
Console.WriteLine($"Insert 후: {string.Join(", ", numbers)}");

// 요소 삭제
numbers.Remove(30);       // 값으로 삭제
Console.WriteLine($"Remove 후: {string.Join(", ", numbers)}");

numbers.RemoveAt(0);      // 인덱스로 삭제
Console.WriteLine($"RemoveAt 후: {string.Join(", ", numbers)}");

// 요소 검색
bool hasForty = numbers.Contains(40);
int indexOfTwenty = numbers.IndexOf(20);
Console.WriteLine($"\n40 포함 여부: {hasForty}");
Console.WriteLine($"20의 인덱스: {indexOfTwenty}");

bool has50 = numbers.Remove(50);
Console.WriteLine($"\n50??: {has50}");


// 정렬
numbers.Add(15);
numbers.Sort();
Console.WriteLine($"\n정렬 후: {string.Join(", ", numbers)}");

// 역순 정렬
numbers.Reverse();
Console.WriteLine($"역순 후: {string.Join(", ", numbers)}");