// ExFinalMaybe.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <sstream>
#include <vector>
#include <stdexcept> // Para tratamento de exceções
#include <locale>
#include <fstream>
#include <typeinfo>
#include <windows.h>


using namespace std;

class Contacto {
private:
    int numero;
    string nome;
    string telefone;
    string email;



public:
    Contacto(int vNumero, string vNome, string vTelefone, string vEmail) {
        numero = vNumero;
        nome = vNome;
        telefone = vTelefone;
        email = vEmail;
    }

    int getNumero()
    {
        return numero;
    }

    string getNome()
    {
        return nome;
    }


    string getTelefone()
    {
        return telefone;
    }

    string getEmail()
    {
        return email;
    }


    int setNumero(int novoNumero) {
    
        numero = novoNumero;
    
    }

    string setNome(string novoNome) {
        
        nome = novoNome;

    }

    string setTelefone(string novoTelefone) {

        telefone = novoTelefone;

    }

    string setEmail(string novoEmail) {
    
        email = novoEmail;
    
    }


};


class Agenda {
private:

    vector<Contacto> contactos;

public:

    vector<Contacto> getContactos() {
    
        return contactos;
    
    }

    void adicionarContacto(int counter)
    {
        string nome, email, telefone;
        int numero, stopper, stopper2;

        stopper = 0;//Usado como termo de paragem na confirmação de repetição de numeros
        stopper2 = 0;//Usado como termo de paragem na confirmação de repetição de telefones





        if (counter == 0) { //Define o primeiro contacto de todos, no caso de uma lista vazia
            cout << "Por favor introduza o seu número de identificação de cliente:\n-";
            cin.ignore();
            cin >> numero;


        }
        else {

            while (stopper == 0) { //Insere contactos posteriormente ao primeiro, ou na eventualidade de existir o primeiro

                cout << "Por favor introduza o seu número de identificação de cliente:\n-";
                cin.ignore();
                cin >> numero;

                for (int i = 0; i < counter;i++) { //Confirmação da existencia de um número igual


                    if (contactos[i].getNumero() == numero) {

                        cout << "\nErro número já existente\n";
                        break;

                    }

                    else {

                        stopper = 1;
                        break;

                    }



                }


            }


        }

        cout << "Por favor introduza o seu nome completo: \n-"; //Inserção do nome
        cin.ignore();
        getline(cin, nome);



        if (counter == 0) {//Inserção do primeiro número de telefone da lista
            cout << "Por favor introduza o seu número de telefone:\n-";
            cin.ignore();
            cin >> telefone;


        }
        else {

            while (stopper2 == 0) { //Inserção de números em contactos depois do primeiro.

                cout << "Por favor introduza o seu número de telefone:\n-";
                cin.ignore();
                cin >> telefone;

                for (int i = 0; i < counter;i++) {//Confirmação da existência de um numero de telefone já inserido


                    if (contactos[i].getTelefone() == telefone) {

                        cout << "\nErro telefone já existente\n";
                        break;

                    }

                    else {

                        stopper2 = 1;
                        break;

                    }



                }


            }


        }



        cout << "Por favor introduza o seu email:  \n-";
        cin.ignore();
        getline(cin, email);

        Contacto novoContacto(numero, nome, telefone, email); //Criação do contacto pelo metodo, através das variáveis armazenadas
        contactos.push_back(novoContacto);//Inserir o contacto no fim do vetor de contactos.

      


    }



    void adicionarLinhaTextoAoPDF(std::ofstream& file, const std::string& texto, bool isHeader) //Função complementar da criação do pdf
    {
        static int lineCount = 0;
        const int lineHeight = 12;
        int yPos = 700 - (lineCount * lineHeight);
        int fontSize = isHeader ? 18 : 12;


        file << "BT\n"
            << "   /F1 " << fontSize << " Tf\n"
            << "   50 " << yPos << " Td\n"
            << "(" << texto << ") Tj\n"
            << "ET\n";

        lineCount++;
    }

    void listarContactos(int counter) { //Listagem dos contactos na execução do programa
        int paramIni, paramFin; //Parametros de inicio e fim to intervalo de listagem
        int stopper = 0; //Paragem de verificação de validade do intervalo

        if (counter > 0) {

            while (stopper < 1) { //Verificação da validade de parâmetros

                cout << "\nPor favor introduza o numero a partir do qual deseja inicializar a visualisação da lista:\n-";
                cin >> paramIni;
                cout << "\nPor favor introduza o numero a partir do qual deseja concluir a visualisação da lista:\n-";
                cin >> paramFin;

                if (paramIni > paramFin || paramIni<0 || paramIni>counter || paramFin > counter) { //Exceções de intervalo

                    cout << "\nInterva-lo inválido tente novamente.\n";

                }
                else {

                    stopper = 1;
                }


            }


            for (int i = (paramIni - 1); i <= (paramFin - 1);i++) {  //intervalo de listagem (o utilizador normal não contará o 0 como o primeiro mas sim o 1, sendo necessário o ajuste de -1 ao seu input)
                cout << contactos[i].getNumero() << " | " << contactos[i].getNome() << " | " << contactos[i].getTelefone() << " | " << contactos[i].getEmail() << "\n";

            }



        }
        else {

            cout << "\nNão existem registos, escolha outra opção";

        }




    }

    void guardarContactos(int counter) { //Guardar a listagem na execução currente para um ficheiro txt(se já existir é substituido)

        cout << "Guardado no ficheiro: ListaContactos.txt";
        ofstream myfile;
        myfile.open("ListaContactos.txt");


        for (int i = 0; i < counter;i++) { //Guardar os contactos, linha a linha separados pelo simbolo "|"
            myfile << contactos[i].getNumero() << " | " << contactos[i].getNome() << " | " << contactos[i].getTelefone() << " | " << contactos[i].getEmail() << "\n";

        }
        myfile.close();
    }

    int guardarPDF(int counter) { //Template default de criação do pdf, mudando apenas o título do documento, e o nome do mesmo.

        const std::string inputFile = "ListaContactos.txt";  	// nome do ficheiro de texto que pretendemos ler
        const std::string outputFile = "ListaContactos.pdf"; 	// ficheiro que vai ser criado 

        // Abra o arquivo de saída
        std::ofstream file(outputFile, std::ios::binary);
        if (!file)
        {
            std::cout << "Falha ao abrir o arquivo de saída." << std::endl;
            return 1;
        }

        // Escreva o cabeçalho do PDF
        file << "%PDF-1.7\n%\xE2\xE3\xCF\xD3\n";

        // Escreva os objetos do PDF necessários
        file << "1 0 obj\n"
            "<< /Type /Catalog\n"
            "   /Pages 2 0 R\n"
            ">>\n"
            "endobj\n"
            "2 0 obj\n"
            "<< /Type /Pages\n"
            "   /Kids [3 0 R]\n"
            "   /Count 1\n"
            ">>\n"
            "endobj\n"
            "3 0 obj\n"
            "<< /Type /Page\n"
            "   /Parent 2 0 R\n"
            "   /Resources << /Font << /F1 4 0 R >> >>\n"
            "   /MediaBox [0 0 612 792]\n"
            "   /Contents 5 0 R\n"
            ">>\n"
            "endobj\n"
            "4 0 obj\n"
            "<< /Type /Font\n"
            "   /Subtype /Type1\n"
            "   /Name /F1\n"
            "   /BaseFont / \n"  // Verdana   Helvetica  Calibri  Tahoma
            "   /Encoding /WinAnsiEncoding\n" // MacRomanEncoding para Mac
            ">>\n"
            "endobj\n"
            "5 0 obj\n"
            "<< /Length 44 >>\n"
            "stream\n";

        // Abra o arquivo de entrada para leitura
        std::ifstream inputFileStream(inputFile);
        if (!inputFileStream)
        {
            std::cout << "Falha ao abrir o arquivo de entrada." << std::endl;
            file.close();
            return 1;
        }

        std::string line;
        adicionarLinhaTextoAoPDF(file, "Lista de Contactos", true);
        file << "\n\n";
        while (std::getline(inputFileStream, line))  // Ler sequencialmente o ficheiro de texto
        {
            // Adicione cada linha do arquivo ao conteúdo do PDF
            adicionarLinhaTextoAoPDF(file, line, false);                // Imprimir linha a linha
            file << "\n";
        }

        // Escreva o restante do conteúdo do PDF
        file << "endstream\n"
            "endobj\n"
            "xref\n"
            "0 6\n"
            "0000000000 65535 f\n"
            "0000000009 00000 n\n"
            "0000000074 00000 n\n"
            "0000000129 00000 n\n"
            "0000000240 00000 n\n"
            "0000000360 00000 n\n"
            "trailer\n"
            "<< /Size 6\n"
            "   /Root 1 0 R\n"
            ">>\n"
            "startxref\n"
            "464\n"
            "%%EOF\n";

        // Feche os arquivos
        inputFileStream.close();
        file.close();

        std::cout << "Ficheiro PDF gerado com sucesso." << std::endl;


    }


    void imprimir() { //Impressão da listagem currente na execução do programa

        system("notepad /p ListaContactos.txt");

    }

    void carregarFicheiro() { //(Não funcional)Carregar o ficheiro de txt para a listagem currente no sistema

        ifstream ficheiro;
        int contador = 0;
        ficheiro.open("ListaContactos.txt");
        /*
        if (ficheiro.is_open()) {
            string linha;
            int numero,size;
            char requirement = 'a';
            size = 0;

            while (getline(ficheiro, linha, '\n')) {

                cout << "\n" << linha << "\n";
                cout << "Tamanho: " << linha.length() << " carateres.\n";
                requirement = 'a';

                string  nome, email, telefone;

                for (int i = 0; i < linha.length();i++) {

                    size++;


                    if (i == 0) {
                        numero = linha[i] - '0';

                    }
                    else if (i >= 3 && linha[i] != '|' && requirement == 'a') {

                        nome = nome.append(1, linha[i]);
                        cout << "Galinhas";

                    }
                    else if(i>=3 && requirement == 'a') {
                        requirement='b';
                        break;
                    }

                    if (i >= 3 && linha[i] != '|' && requirement == 'b') {

                        telefone = telefone.append(1, linha[i]);
                        cout << "Patos";

                    }
                    else if (i>=3 && requirement =='b') {
                        requirement = 'c';
                        break;
                    }
                    if (i >= 3 && linha[i] != '|' && requirement ='c') {

                        email = email.append(1,linha[i]);
                        cout << "Ganços";

                    }
                    
                    

                }


                cout << "\nNome:" << nome;
                cout << "\nNumero: " << numero;
                cout << "\nEmail: " << email << "\n";
                Contacto novoContacto(numero, nome, telefone, email);
                contactos.push_back(novoContacto);
                


            }






        }
        */ //Tentativa 1
        //^Tentativa 1

        string dado, linha;

        while (getline(ficheiro, linha)) { //Ler o ficheiro linha a linha

            string nome, email, telefone;
            int numero;

            stringstream separador(linha); //Separador servirá para ler as parcelas do vetor até encontrar o simbolo definido como tal, neste caso o "|"

            getline(separador, dado, '|');

            numero = stoi(dado);
          

            getline(separador, dado, '|');

            nome = dado;

            

            getline(separador, dado, '|');

            telefone = dado;
            

            getline(separador, dado, '|');

            email=dado;

         


            Contacto novoContacto(numero, nome, telefone, email); //Inserção do contacto da lista no vetor dentro do programa.
            contactos.push_back(novoContacto);
            

        };




    }
};


int main()
{
    setlocale(LC_ALL, "Portuguese");


    Agenda agendas;
    agendas.carregarFicheiro();
    int counter = agendas.getContactos().size();


    while (true) {//Ciclo responsável pela impressão e seleção do menu

        cout << "\n::: Menu:::\n\n";
        cout << "Escolha uma opção:\n";
        cout << "1. Adicionar Contacto\n";
        cout << "2. Listar contactos\n";
        cout << "3. Gerar PDF\n";
        cout << "4. Imprimir Agenda\n";
        cout << "5. Guardar em ficheiro de texto\n";
        cout << "6. Carregar Ficheiro\n";
        cout << "0. Sair\n-";



        int opcao;
        cin >> opcao;

        switch (opcao) {

        case 1: {

            agendas.adicionarContacto(counter);
            counter++; //adiciona ao counter responsável pelo armazenamento do número de contactos
            break; }

        case 2: {
            agendas.listarContactos(counter);

            break; }
        case 3: {

            agendas.guardarPDF(counter);
            break;}

        case 4: {

            agendas.imprimir();
            break; 
        }

        case 5: {

            agendas.guardarContactos(counter);
            break;

        }
        case 6: {

            agendas.carregarFicheiro();
            break;
        }
        case 0: {

            agendas.guardarContactos(counter);
            exit(true);
            break; 
        
        }
        
        default: {

            cout << "Opção inválida. Tente novamente." << endl; }

        }

    }
    system("pause");
    return 0;
}
// ExFinalMaybe.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <sstream>
#include <vector>
#include <stdexcept> // Para tratamento de exceções
#include <locale>
#include <fstream>
#include <typeinfo>
#include <windows.h>


using namespace std;

class Contacto {
private:
    int numero;
    string nome;
    string telefone;
    string email;



public:
    Contacto(int vNumero, string vNome, string vTelefone, string vEmail) {
        numero = vNumero;
        nome = vNome;
        telefone = vTelefone;
        email = vEmail;
    }

    int getNumero()
    {
        return numero;
    }

    string getNome()
    {
        return nome;
    }


    string getTelefone()
    {
        return telefone;
    }

    string getEmail()
    {
        return email;
    }


    int setNumero(int novoNumero) {
    
        numero = novoNumero;
    
    }

    string setNome(string novoNome) {
        
        nome = novoNome;

    }

    string setTelefone(string novoTelefone) {

        telefone = novoTelefone;

    }

    string setEmail(string novoEmail) {
    
        email = novoEmail;
    
    }


};


class Agenda {
private:

    vector<Contacto> contactos;

public:

    vector<Contacto> getContactos() {
    
        return contactos;
    
    }

    void adicionarContacto(int counter)
    {
        string nome, email, telefone;
        int numero, stopper, stopper2;

        stopper = 0;//Usado como termo de paragem na confirmação de repetição de numeros
        stopper2 = 0;//Usado como termo de paragem na confirmação de repetição de telefones





        if (counter == 0) { //Define o primeiro contacto de todos, no caso de uma lista vazia
            cout << "Por favor introduza o seu número de identificação de cliente:\n-";
            cin.ignore();
            cin >> numero;


        }
        else {

            while (stopper == 0) { //Insere contactos posteriormente ao primeiro, ou na eventualidade de existir o primeiro

                cout << "Por favor introduza o seu número de identificação de cliente:\n-";
                cin.ignore();
                cin >> numero;

                for (int i = 0; i < counter;i++) { //Confirmação da existencia de um número igual


                    if (contactos[i].getNumero() == numero) {

                        cout << "\nErro número já existente\n";
                        break;

                    }

                    else {

                        stopper = 1;
                        break;

                    }



                }


            }


        }

        cout << "Por favor introduza o seu nome completo: \n-"; //Inserção do nome
        cin.ignore();
        getline(cin, nome);



        if (counter == 0) {//Inserção do primeiro número de telefone da lista
            cout << "Por favor introduza o seu número de telefone:\n-";
            cin.ignore();
            cin >> telefone;


        }
        else {

            while (stopper2 == 0) { //Inserção de números em contactos depois do primeiro.

                cout << "Por favor introduza o seu número de telefone:\n-";
                cin.ignore();
                cin >> telefone;

                for (int i = 0; i < counter;i++) {//Confirmação da existência de um numero de telefone já inserido


                    if (contactos[i].getTelefone() == telefone) {

                        cout << "\nErro telefone já existente\n";
                        break;

                    }

                    else {

                        stopper2 = 1;
                        break;

                    }



                }


            }


        }



        cout << "Por favor introduza o seu email:  \n-";
        cin.ignore();
        getline(cin, email);

        Contacto novoContacto(numero, nome, telefone, email); //Criação do contacto pelo metodo, através das variáveis armazenadas
        contactos.push_back(novoContacto);//Inserir o contacto no fim do vetor de contactos.

      


    }



    void adicionarLinhaTextoAoPDF(std::ofstream& file, const std::string& texto, bool isHeader) //Função complementar da criação do pdf
    {
        static int lineCount = 0;
        const int lineHeight = 12;
        int yPos = 700 - (lineCount * lineHeight);
        int fontSize = isHeader ? 18 : 12;


        file << "BT\n"
            << "   /F1 " << fontSize << " Tf\n"
            << "   50 " << yPos << " Td\n"
            << "(" << texto << ") Tj\n"
            << "ET\n";

        lineCount++;
    }

    void listarContactos(int counter) { //Listagem dos contactos na execução do programa
        int paramIni, paramFin; //Parametros de inicio e fim to intervalo de listagem
        int stopper = 0; //Paragem de verificação de validade do intervalo

        if (counter > 0) {

            while (stopper < 1) { //Verificação da validade de parâmetros

                cout << "\nPor favor introduza o numero a partir do qual deseja inicializar a visualisação da lista:\n-";
                cin >> paramIni;
                cout << "\nPor favor introduza o numero a partir do qual deseja concluir a visualisação da lista:\n-";
                cin >> paramFin;

                if (paramIni > paramFin || paramIni<0 || paramIni>counter || paramFin > counter) { //Exceções de intervalo

                    cout << "\nInterva-lo inválido tente novamente.\n";

                }
                else {

                    stopper = 1;
                }


            }


            for (int i = (paramIni - 1); i <= (paramFin - 1);i++) {  //intervalo de listagem (o utilizador normal não contará o 0 como o primeiro mas sim o 1, sendo necessário o ajuste de -1 ao seu input)
                cout << contactos[i].getNumero() << " | " << contactos[i].getNome() << " | " << contactos[i].getTelefone() << " | " << contactos[i].getEmail() << "\n";

            }



        }
        else {

            cout << "\nNão existem registos, escolha outra opção";

        }




    }

    void guardarContactos(int counter) { //Guardar a listagem na execução currente para um ficheiro txt(se já existir é substituido)

        cout << "Guardado no ficheiro: ListaContactos.txt";
        ofstream myfile;
        myfile.open("ListaContactos.txt");


        for (int i = 0; i < counter;i++) { //Guardar os contactos, linha a linha separados pelo simbolo "|"
            myfile << contactos[i].getNumero() << " | " << contactos[i].getNome() << " | " << contactos[i].getTelefone() << " | " << contactos[i].getEmail() << "\n";

        }
        myfile.close();
    }

    int guardarPDF(int counter) { //Template default de criação do pdf, mudando apenas o título do documento, e o nome do mesmo.

        const std::string inputFile = "ListaContactos.txt";  	// nome do ficheiro de texto que pretendemos ler
        const std::string outputFile = "ListaContactos.pdf"; 	// ficheiro que vai ser criado 

        // Abra o arquivo de saída
        std::ofstream file(outputFile, std::ios::binary);
        if (!file)
        {
            std::cout << "Falha ao abrir o arquivo de saída." << std::endl;
            return 1;
        }

        // Escreva o cabeçalho do PDF
        file << "%PDF-1.7\n%\xE2\xE3\xCF\xD3\n";

        // Escreva os objetos do PDF necessários
        file << "1 0 obj\n"
            "<< /Type /Catalog\n"
            "   /Pages 2 0 R\n"
            ">>\n"
            "endobj\n"
            "2 0 obj\n"
            "<< /Type /Pages\n"
            "   /Kids [3 0 R]\n"
            "   /Count 1\n"
            ">>\n"
            "endobj\n"
            "3 0 obj\n"
            "<< /Type /Page\n"
            "   /Parent 2 0 R\n"
            "   /Resources << /Font << /F1 4 0 R >> >>\n"
            "   /MediaBox [0 0 612 792]\n"
            "   /Contents 5 0 R\n"
            ">>\n"
            "endobj\n"
            "4 0 obj\n"
            "<< /Type /Font\n"
            "   /Subtype /Type1\n"
            "   /Name /F1\n"
            "   /BaseFont / \n"  // Verdana   Helvetica  Calibri  Tahoma
            "   /Encoding /WinAnsiEncoding\n" // MacRomanEncoding para Mac
            ">>\n"
            "endobj\n"
            "5 0 obj\n"
            "<< /Length 44 >>\n"
            "stream\n";

        // Abra o arquivo de entrada para leitura
        std::ifstream inputFileStream(inputFile);
        if (!inputFileStream)
        {
            std::cout << "Falha ao abrir o arquivo de entrada." << std::endl;
            file.close();
            return 1;
        }

        std::string line;
        adicionarLinhaTextoAoPDF(file, "Lista de Contactos", true);
        file << "\n\n";
        while (std::getline(inputFileStream, line))  // Ler sequencialmente o ficheiro de texto
        {
            // Adicione cada linha do arquivo ao conteúdo do PDF
            adicionarLinhaTextoAoPDF(file, line, false);                // Imprimir linha a linha
            file << "\n";
        }

        // Escreva o restante do conteúdo do PDF
        file << "endstream\n"
            "endobj\n"
            "xref\n"
            "0 6\n"
            "0000000000 65535 f\n"
            "0000000009 00000 n\n"
            "0000000074 00000 n\n"
            "0000000129 00000 n\n"
            "0000000240 00000 n\n"
            "0000000360 00000 n\n"
            "trailer\n"
            "<< /Size 6\n"
            "   /Root 1 0 R\n"
            ">>\n"
            "startxref\n"
            "464\n"
            "%%EOF\n";

        // Feche os arquivos
        inputFileStream.close();
        file.close();

        std::cout << "Ficheiro PDF gerado com sucesso." << std::endl;


    }


    void imprimir() { //Impressão da listagem currente na execução do programa

        system("notepad /p ListaContactos.txt");

    }

    void carregarFicheiro() { //(Não funcional)Carregar o ficheiro de txt para a listagem currente no sistema

        ifstream ficheiro;
        int contador = 0;
        ficheiro.open("ListaContactos.txt");
        /*
        if (ficheiro.is_open()) {
            string linha;
            int numero,size;
            char requirement = 'a';
            size = 0;

            while (getline(ficheiro, linha, '\n')) {

                cout << "\n" << linha << "\n";
                cout << "Tamanho: " << linha.length() << " carateres.\n";
                requirement = 'a';

                string  nome, email, telefone;

                for (int i = 0; i < linha.length();i++) {

                    size++;


                    if (i == 0) {
                        numero = linha[i] - '0';

                    }
                    else if (i >= 3 && linha[i] != '|' && requirement == 'a') {

                        nome = nome.append(1, linha[i]);
                        cout << "Galinhas";

                    }
                    else if(i>=3 && requirement == 'a') {
                        requirement='b';
                        break;
                    }

                    if (i >= 3 && linha[i] != '|' && requirement == 'b') {

                        telefone = telefone.append(1, linha[i]);
                        cout << "Patos";

                    }
                    else if (i>=3 && requirement =='b') {
                        requirement = 'c';
                        break;
                    }
                    if (i >= 3 && linha[i] != '|' && requirement ='c') {

                        email = email.append(1,linha[i]);
                        cout << "Ganços";

                    }
                    
                    

                }


                cout << "\nNome:" << nome;
                cout << "\nNumero: " << numero;
                cout << "\nEmail: " << email << "\n";
                Contacto novoContacto(numero, nome, telefone, email);
                contactos.push_back(novoContacto);
                


            }






        }
        */ //Tentativa 1
        //^Tentativa 1

        string dado, linha;

        while (getline(ficheiro, linha)) { //Ler o ficheiro linha a linha

            string nome, email, telefone;
            int numero;

            stringstream separador(linha); //Separador servirá para ler as parcelas do vetor até encontrar o simbolo definido como tal, neste caso o "|"

            getline(separador, dado, '|');

            numero = stoi(dado);
          

            getline(separador, dado, '|');

            nome = dado;

            

            getline(separador, dado, '|');

            telefone = dado;
            

            getline(separador, dado, '|');

            email=dado;

         


            Contacto novoContacto(numero, nome, telefone, email); //Inserção do contacto da lista no vetor dentro do programa.
            contactos.push_back(novoContacto);
            

        };




    }
};


int main()
{
    setlocale(LC_ALL, "Portuguese");


    Agenda agendas;
    agendas.carregarFicheiro();
    int counter = agendas.getContactos().size();


    while (true) {//Ciclo responsável pela impressão e seleção do menu

        cout << "\n::: Menu:::\n\n";
        cout << "Escolha uma opção:\n";
        cout << "1. Adicionar Contacto\n";
        cout << "2. Listar contactos\n";
        cout << "3. Gerar PDF\n";
        cout << "4. Imprimir Agenda\n";
        cout << "5. Guardar em ficheiro de texto\n";
        cout << "6. Carregar Ficheiro\n";
        cout << "0. Sair\n-";



        int opcao;
        cin >> opcao;

        switch (opcao) {

        case 1: {

            agendas.adicionarContacto(counter);
            counter++; //adiciona ao counter responsável pelo armazenamento do número de contactos
            break; }

        case 2: {
            agendas.listarContactos(counter);

            break; }
        case 3: {

            agendas.guardarPDF(counter);
            break;}

        case 4: {

            agendas.imprimir();
            break; 
        }

        case 5: {

            agendas.guardarContactos(counter);
            break;

        }
        case 6: {

            agendas.carregarFicheiro();
            break;
        }
        case 0: {

            agendas.guardarContactos(counter);
            exit(true);
            break; 
        
        }
        
        default: {

            cout << "Opção inválida. Tente novamente." << endl; }

        }

    }
    system("pause");
    return 0;
}
