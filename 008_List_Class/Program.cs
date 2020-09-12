using System;
using System.Text;
using System.Collections.Generic;

public class Example
    {
    private static void Display(LinkedList<string> words, string test)
    {
        Console.WriteLine(test);
        foreach (string word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }


    
        
    public static void Main()    
    {

        #region Test1: Создание связанного списка
                
        string[] words = { "the", "fox", "jumped", "over", "the", "dog" };
                
        LinkedList<string> sentence = new LinkedList<string>(words);
        
        Display(sentence, "Элементы связанного списка: ");

        #endregion

        #region Test2: Метод Contains определяет, принадлежит ли значение объекту LinkedList<T>.

        Console.WriteLine("Test 2: List sentence contains \"jumped\" = {0} \n", sentence.Contains("jumped"));

        #endregion

        #region Test3: Добавление слова 'today' в начало связанного списка.

        sentence.AddFirst("today");
        Display(sentence, "Test 3: Добавление слова 'today' в начало связанного списка");

        #endregion

        #region Test 4: Удаления первого элемента с добавлением его в конец списка.

        // Инициализирует новый экземпляр класса LinkedListNode<T> содержащего указанное значение.
        LinkedListNode<string> mark1 = sentence.First;  
        
        sentence.RemoveFirst();
        sentence.AddLast(mark1);
        
        Display(sentence, "Test 4: Удаления первого элемента с добавлением его в конец списка");

        #endregion

        #region Test 5: Замена последнего элемента на 'yesterday'.
        
        sentence.RemoveLast();
        sentence.AddLast("yesterday");
        Display(sentence, "Test 5: Замена последнего элемента на 'yesterday':");

        #endregion

        #region Test 6: Перемещение последнего элемента на первую позицию   
                
        mark1 = sentence.Last;
        
        sentence.RemoveLast();
        sentence.AddFirst(mark1);
        Display(sentence, "Test 6: Перемещение последнего элемента на первую позицию:");   

        #endregion

        #region Test 7: Нахождение последнего из списка искомого элемента 
                
        
        LinkedListNode<string> current = sentence.FindLast("the");
        
      
        
        #endregion

        #region Test 8: Добавить 'lazy' и 'old' после элемента 'the'
        
        sentence.AddAfter(current, "old");
        sentence.AddAfter(current, "lazy");
       

        Display(sentence, "Test 8. Show:");
        
        #endregion

        #region Test 9: Удаление произвольного элемента из списка         
        
        sentence.Remove("lazy");
        Display(sentence, "Удаление произвольного элемента из списка:");
        
        
        
        #endregion
                             
        Console.ReadLine();
    }
        
}


