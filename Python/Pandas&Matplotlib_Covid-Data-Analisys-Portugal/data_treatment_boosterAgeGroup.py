import pandas as pd
import matplotlib.pyplot as plt

#Importação das bibliotecas para tratamento de dados e geração de gráficos
df = pd.read_csv('vacinas.csv')
# excluir linhas vazias
df = df.dropna(how='all')
# excluir duplicados
df = df.drop_duplicates()
#^até aqui obrigatorio no tratamento de dados
# excluir espaços em branco no inicio e fim
df = df.rename(columns=lambda x: x.strip())
# renomear as colunas
df = df.rename(columns={'data': 'Data'})
df = df.rename(columns={'reforço_80mais_novas': '80+'},)
df = df.rename(columns={'reforço_70_79_novas' : '70-79'})
df = df.rename(columns={'reforço_60_69_novas' : '60-69'})
df = df.rename(columns={'reforço_50_59_novas' : '50-59'})
df = df.rename(columns={'reforço_40_49_novas' : '40-49'})
df = df.rename(columns={'reforço_30_39_novas' : '30-39'})
df = df.rename(columns={'reforço_18_29_novas' : '18-29'})
#tirar linhas onde não houve vacinação
df = df.dropna(how='all', subset=['80+', '70-79', '60-69','50-59', '40-49', '30-39','18-29'])
#atribuir apenas as colunas necessárias ao estudo, ao dataframe (neste caso as vacinações)
df = df[['Data','80+','70-79','60-69','50-59','40-49','30-39','18-29']]
#gravar o ficheiro
df.to_csv('vacinas_refoco_diaria.csv', index=False)

