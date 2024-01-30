#include <iostream>
#include <locale.h>

static void ImprimeMenuPT(){
	std::cout<<"Por favor selecione uma das seguintes opções:\n";
	std::cout<<"1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n 5 - English\n0 - Sair\n";	
}

static void ImprimeMenuEN(){
	std::cout<<"Please select one of the following options:\n";
	std::cout<<"1 - Sum\n2 - Subtraction\n3 - Multiplication\n4 - Division\n 5 - Portugues\n0 - Exit\n";
	
}

int main() {
	
	/* int userNum1;
	int userNum2;
	char operacao;
	float resultado;
	
	
	std::cout<<"Por favor introduza o primeiro algarismo: \n";
	std::cin>>userNum1;
	std::cout<<"\nPor favor introduza o segundo algarismo: \n";
	std::cin>>userNum2;
	
	std::cout<<"\nPor favor introduza o carater indicado de acordo com a operacao desejada: \n";
	std::cout<<"\nPara somar introduza -> + \nPara subtrair introduza -> - \nPara multiplicar introduza -> * \nPara dividir introduza -> / \n";
	std::cin>>operacao;
	
	if (operacao=='+'){
		resultado = userNum1 + userNum2;
	}
	else if (operacao =='-'){
		resultado = userNum1 - userNum2;
	}
	else if (operacao =='*'){
		resultado = userNum1*userNum2;
	}
	else if (operacao == '/'){
		resultado = userNum1/userNum2;
	}
	
	std::cout<<"O resultado de"<<userNum1<<operacao<<userNum2<<" e de: "<<resultado; */

	setlocale(LC_ALL,"portuguese");
	int ENstopper = 1;
	int PTstopper = 1;
	int language =0;

	std::cout<<"Por favor selecione uma lingua/Please select a language: \n";
	std::cout<<"0 - English\n1 - Portuguese";
	std::cin>>language;

while(true){
switch(language){
		case 0:
			while(ENstopper!=0){
	
				int option;
				float userNum1,userNum2,result;
				ImprimeMenuEN();
				std::cin>>option;
		
				switch(option){
					case 1:
					std::cout<<"\nSum\n\n";
					std::cout<<"Please insert your first number:\n";
					std::cin>>userNum1;
					std::cout<<"Please insert your second number:\n";
					std::cin>>userNum2;
					result = userNum1 + userNum2;
					std::cout<<"The result of the sum of "<<userNum1<<" and "<<userNum2<<" is "<<result<<std::endl;
					break;
		
					case 2:
		
					std::cout<<"Subtraction";
					std::cout<<"Please insert your first number:\n";
					std::cin>>userNum1;
					std::cout<<"Please insert your second number:\n";
					std::cin>>userNum2;
					result = userNum1 - userNum2;
					std::cout<<"The result of the subtraction of "<<userNum1<<" from "<<userNum2<<" is "<<result<<std::endl;
					break;
		
					case 3:
		
					std::cout<<"Multiplication";
					std::cout<<"Please insert your first number:\n";
					std::cin>>userNum1;
					std::cout<<"Please insert your second number:\n";
					std::cin>>userNum2;
					result = userNum1 * userNum2;
					std::cout<<"The result of the multiplication of "<<userNum1<<" by "<<userNum2<<" is "<<result<<std::endl;
					break;
		
					case 4:
		
					std::cout<<"Division";
					std::cout<<"Please insert your first number:\n";
					std::cin>>userNum1;
					std::cout<<"Please insert your second number:\n";
					std::cin>>userNum2;
					result = userNum1 / userNum2;
					std::cout<<"The result of the division of "<<userNum1<<" by "<<userNum2<<" is "<<result<<std::endl;
					break;
		
					case 5:
					language=1;
					ENstopper =0;
					PTstopper =1;
					break;
		
					case 0:
					exit;
					break;
					
		
				};
				
			};
			break;

		case 1:
		while(PTstopper!=0){

		int option;
		float userNum1,userNum2,result;
		ImprimeMenuPT();
		std::cin>>option;

		switch(option){
			case 1:
			std::cout<<"Soma";
			std::cout<<"Por favor insira o seu primeiro numero:\n";
			std::cin>>userNum1;
			std::cout<<"Por favor insira o seu segundo numero:\n";
			std::cin>>userNum2;
			result = userNum1 + userNum2;
			std::cout<<"O resultado da some de "<<userNum1<<" e "<<userNum2<<" é "<<result<<std::endl;
			break;

			case 2:

			std::cout<<"Subtração";
			std::cout<<"Por favor insira o seu primeiro numero:\n";
			std::cin>>userNum1;
			std::cout<<"Por favor insira o seu segundo numero:\n";
			std::cin>>userNum2;
			result = userNum1 - userNum2;
			std::cout<<"O resultado da subtração de "<<userNum1<<" por "<<userNum2<<" é "<<result<<std::endl;
			break;

			case 3:

			std::cout<<"Multiplicação";
			std::cout<<"Por favor insira o seu primeiro numero:\n";
			std::cin>>userNum1;
			std::cout<<"Por favor insira o seu segundo numero:\n";
			std::cin>>userNum2;
			result = userNum1 * userNum2;
			std::cout<<"O resultado da multiplicação de "<<userNum1<<" por "<<userNum2<<" é "<<result<<std::endl;
			break;

			case 4:

			std::cout<<"Divisão";
			std::cout<<"Por favor insira o seu primeiro numero:\n";
			std::cin>>userNum1;
			std::cout<<"Por favor insira o seu segundo numero:\n";
			std::cin>>userNum2;
			result = userNum1 / userNum2;
			std::cout<<"O resultado da divisão de "<<userNum1<<" por "<<userNum2<<" é "<<result<<std::endl;
			break;

			case 5:
			language=0;
			ENstopper =1;
			PTstopper =0;
			break;

			case 0:
			exit;
			break;

		};
		};
		break;
}
	

	








	}
	return 0;
}
	

