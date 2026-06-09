#include <iostream>
#include <string>

int main(int argc, char** argv)
{
	std::string arg = (argc > 1) ? argv[1] : "";
	if (arg == "--version" || arg == "-v") {
		std::cout << "Wrapper111.exe version 1.0" << std::endl;
		return 0;
	}

	if (arg == "--status") {
		std::cout << "Status: OK" << std::endl;
		return 0;
	}

	std::cout << "Wrapper111.exe - простая тестовая программа" << std::endl;
	std::cout << "Использование: 111.exe [--version|-v|--status]" << std::endl;
	return 0;
}
