import pandas as pd
import matplotlib.pyplot as plt
import numpy as np
# Carregar informação do ficheiro
df = pd.read_csv('vacinas.csv', sep=',')
# Eliminar linhas vazias
df = df.dropna(how='all')
# Eliminar duplicadas
dforiginal = df.drop_duplicates()
# Renomear as colunas
df = df.rename(columns=lambda x: x.strip())
# Meter a data apenas para ano e mês
df = df.rename(columns={'data': 'Date'})
df['Date'] = pd.to_datetime(df['Date'], dayfirst=True)
df['Date'] = df['Date'].dt.strftime('%Y-%m')
#Renomear as outras colunas
df = df.rename(columns={'doses_novas': 'Dosages Received'})
df = df.rename(columns={'doses1_novas': '1st Dosage'})
df = df.rename(columns={'doses2_novas': '2nd Dosage'})
# Atribuir apenas as colunas necessárias ao estudo, ao dataframe (neste caso as doses)
df = df[['Date', 'Dosages Received', '1st Dosage', '2nd Dosage']]
df = df.dropna(how='all', subset=['Dosages Received', '1st Dosage', '2nd Dosage'])
# Gravar o ficheiro
df.to_csv('doses_diaria.csv', index=False)
# Agrupamento de dados que queremos ver
gr = df.groupby(df['Date'])['Dosages Received'].sum()
g1r = df.groupby(df['Date'])['1st Dosage'].sum()
g2r = df.groupby(df['Date'])['2nd Dosage'].sum()
#Transformação dos valores em milhões
for g in [gr, g1r,g2r]:
        g[:]=round(g/1000000,2)
# Tamanho da barra
bar_height = 0.2
# Transformar datas em posições do eixo y
date_index = pd.to_datetime(gr.index)
# Ordenar as datas/ posições
bar_positions = np.arange(len(date_index))
#Criar as barras para cada tipo de agrupamento
bargr = plt.barh(bar_positions, (gr.values), height=bar_height, label='Dosages Received', color='r') # type: ignore
barg1r = plt.barh(bar_positions + bar_height, (g1r.values), height=bar_height, label='1st Dosage', color='y') # type: ignore
barg2r = plt.barh(bar_positions + 2 * bar_height, (g2r.values), height=bar_height, label='2nd Dosage', color='g') # type: ignore
#Ciclo para meter o texto em cada barra
for bars, data in zip([bargr, barg1r, barg2r], [gr, g1r, g2r]):
    for bar, value in zip(bars, data.values):
        plt.text(bar.get_width() + 0.05, bar.get_y() + bar.get_height() / 2, str(f'{value}M'),
                 ha='left', va='center', color='black', fontsize=8, rotation=0)
# Dar as labels do gráfico
plt.ylabel('Year-Month')
plt.xlabel('Daily Dosages(in M)')
#Adicionar a grelha
plt.grid(color='black', linestyle='-', linewidth=0.5)
#Titulo do grafico
plt.title('Daily Dosages per Month')
plt.yticks(bar_positions + bar_height, date_index.strftime('%m-%y')) # type: ignore
#Simplificar a numeração
plt.ticklabel_format(axis='x', style='plain')
#legenda do grafico
plt.legend()
plt.show()
