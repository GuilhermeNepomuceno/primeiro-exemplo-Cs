using System;

namespace PrimeiroExemploPraticoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            char userInput;
            Student[] students = new Student[5];
            int studentsIndex = 0;
            do
            {
                Console.Clear();
                userInput = showMenu();

                switch (userInput)
                {
                    case '1':
                        Console.WriteLine("Informe o nome do Aluno(a):");
                        Student newStudent = new Student();
                        newStudent.name = Console.ReadLine();
                        Console.Beep();
                        Console.WriteLine("Informe a nota: ");
                        if (Decimal.TryParse(Console.ReadLine(), out decimal grade))
                        {
                            newStudent.grade = grade;
                        } else
                        {
                            throw new ArgumentException("Valor da nota deve ser do tipo Decimal. Exemplo: 9.5; 7.2");
                        }
                        Console.Beep();
                        students[studentsIndex] = newStudent;
                        studentsIndex++;
                               
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t\t######- Lista de Alunos -######\n");
                        foreach (var student in students)
                        {
                            if (!string.IsNullOrEmpty(student.name))
                            {
                                Console.WriteLine($"#- Aluno {student.name}  #- Nota: {student.grade}");
                            }
                        }
                        Console.WriteLine("\nPressione qualquer tecla para continuar");
                        Console.ReadLine();
                        break;
                    case '3':
                        showAverageGrade(students);
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine("Serviço encerrado");
                    break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            } while (userInput != '4');
        }

        private static void showAverageGrade(Student[] students)
        {
            decimal overallGrade = 0m;
            int studentsQuantity = 0;
            foreach (var student in students)
            {
                if (!string.IsNullOrEmpty(student.name))
                {
                    overallGrade += student.grade;
                    studentsQuantity++;
                }
            }

            Console.Clear();
            calculateAverageGrade(overallGrade, studentsQuantity,out decimal averageGrade);
            Console.WriteLine($"Nota média: {averageGrade}");
            Console.ReadLine();
        }

        private static void calculateAverageGrade(decimal overallGrade, int quantity, out decimal averageGrade){
            averageGrade = overallGrade / quantity;
        }

        private static char showMenu()
        {
            char userInput;
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir Alunos novos");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("4- Sair\n");

            userInput = Console.ReadLine()[0];
            return userInput;
        }
    }
}
