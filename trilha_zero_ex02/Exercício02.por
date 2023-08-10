programa
{
	
	funcao inicio()
	{
		inteiro vetor [10]

		para(inteiro i = 0; i < 10; i++){
			escreva("Digite um número inteiro: ")	
			leia(vetor[i])
		}
		
		trabalhando_vetor(vetor)
		
	}


	funcao trabalhando_vetor(inteiro num[]){
		inteiro soma = 0
		real media = 0
		
		escreva("Elementos nos índices ímpares: \n")
		para(inteiro i =1; i < 10; i+=2){
			escreva(num[i], " ")
		}	

		escreva("\nElementos pares: \n")
		para(inteiro i =0; i < 10; i++){
			soma += num[i]
			se(num[i]%2 == 0){
				escreva(num[i], " ")
			}
		}

		escreva("\nSoma: \n")
		escreva(soma)

		media =  soma/10
		escreva("\nMédia: \n")
		escreva(media)
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 636; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */