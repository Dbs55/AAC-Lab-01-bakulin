// Console.WriteLine($"Компьютер: {Environment.MachineName}");
// Console.WriteLine($"Пользователь: {Environment.UserName}");
// Console.WriteLine($"Дата и время: {DateTime.Now:dd.MM.yyyy HH:mm}");
// Console.WriteLine("\n--- Исследование 1 ---");
// Console.WriteLine($"OC: {Environment.OSVersion}");
// Console.WriteLine($"64-битная OC: {Environment.Is64BitOperatingSystem}");
// Console.WriteLine("\n--- Исследование 2 ---");
// Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");
Console.WriteLine("\n--- Исследование 3 ---");
Console.WriteLine($"PID процесса: {Environment.ProcessId}");
long memory = Environment.WorkingSet / 1024 / 1024;
Console.WriteLine($"Память процесса: {memory} МБ");

Console.WriteLine("\nНажмите Enter для перехода к дополнительному заданию...");
Console.ReadLine();
