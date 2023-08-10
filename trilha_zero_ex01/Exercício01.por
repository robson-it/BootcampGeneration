programa
{
	
	funcao inicio()
	{
		inteiro vetor [10] = {2,3,1,5,6,4,7,9,8,0}
		ordena_vetor(vetor)
		
	}


	funcao ordena_vetor(inteiro num[]){
		inteiro auxiliar = 0
		
		para(inteiro j = 0; j<9 ; j++){
			
			para(inteiro i =0; i < 9; i++){
				se(num[i]<num[i+1]){
					auxiliar = num[i]
					num[i] = num[i+1]
					num[i+1] = auxiliar	
				}
			}
			
		}

		para(inteiro i =0; i < 10; i++){
			escreva(num[i])
		}	
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 431; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */