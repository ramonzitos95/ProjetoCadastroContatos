///
//Essa função utiliza uma pilha para rastrear a ordem dos colchetes. 
//Ela percorre a string de entrada e empurra colchetes de abertura para a pilha. 
//Quando um colchete de fechamento é encontrado, ele é comparado com o colchete no topo da pilha. 
//Se eles formarem um par válido, o colchete de abertura correspondente é retirado da pilha. 
//No final, se a pilha estiver vazia, isso indica que todos os colchetes têm correspondência e a ordem é válida. 
//Caso contrário, a ordem é inválida.

static bool VerificarOrdemColchetes(string input)
{
    Stack<char> stack = new Stack<char>();

    foreach (char ch in input)
    {
        if (ch == '(' || ch == '{' || ch == '[')
        {
            stack.Push(ch);
        }
        else if (ch == ')' || ch == '}' || ch == ']')
        {
            if (stack.Count == 0)
            {
                return false;
            }

            char top = stack.Pop();
            if ((ch == ')' && top != '(') ||
                (ch == '}' && top != '{') ||
                (ch == ']' && top != '['))
            {
                return false;
            }
        }
    }

    return stack.Count == 0;
}

string input1 = "(){}[]";
string input2 = "[{()}](){}";
string input3 = "[]{()";
string input4 = "[{)]";

Console.WriteLine($"{input1} é {(VerificarOrdemColchetes(input1) ? "válido" : "inválido")}");
Console.WriteLine($"{input2} é {(VerificarOrdemColchetes(input2) ? "válido" : "inválido")}");
Console.WriteLine($"{input3} é {(VerificarOrdemColchetes(input3) ? "válido" : "inválido")}");
Console.WriteLine($"{input4} é {(VerificarOrdemColchetes(input4) ? "válido" : "inválido")}");
