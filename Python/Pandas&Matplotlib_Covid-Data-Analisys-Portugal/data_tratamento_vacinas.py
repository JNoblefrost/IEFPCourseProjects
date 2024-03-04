import pandas as pd
import matplotlib.pyplot as plt
import numpy as np
#Carregar dados do csv
df=pd.read_csv('vacinas.csv', sep=',')
#Eliminar vazias
df=df.dropna(how='all')
#Eliminar duplicadas
dforiginal=df.drop_duplicates()
# Renomeas as colunas
df = df.rename(columns=lambda x: x.strip())
df = df.rename(columns={'data': 'Date'})
#Formatar para ficar mes e ano
df['Date']=pd.to_datetime(df['Date'],dayfirst=True)
df['Date'] = df['Date'].dt.strftime('%Y-%m')
#Renomear as outras colunas
df = df.rename(columns={'vacinas_novas': 'Covid Vaccines'},)
df = df.rename(columns={'pessoas_gripe_novas' : 'Flu Shots'})
df = df.rename(columns={'vacinas_reforço_e_gripe_novas' : 'Both Vaccines'})
#Atribuir apenas as colunas necessárias ao estudo, ao dataframe (neste caso as vacinações)
df = df[['Date','Covid Vaccines','Flu Shots','Both Vaccines']]
df = df.dropna(how='all', subset=['Covid Vaccines','Flu Shots','Both Vaccines'])
#Gravar o ficheiro
df.to_csv('covgripe_diaria.csv', index=False)
#Agrupamento de dados que queremos ver
gg=df.groupby(df['Date'])['Flu Shots'].sum()
gc=df.groupby(df['Date'])['Covid Vaccines'].sum()
gd=df.groupby(df['Date'])['Both Vaccines'].sum()
#Transformação dos valores em Milhões
for g in [gg, gc,gd]:
        g[:]=round(g/1000000,2)
#Tamanho da barra
bar_width = 0.2
#Transformar datas em posições do eixo x
date_index = pd.to_datetime(gg.index)
#Ordenar as datas/ posições
bar_positions = np.arange(len(date_index))
#Criar as barras para cada tipo de agrupamento
bargg = plt.barh(bar_positions, gg.values, height=bar_width, label='Flu Shots', color='g') # type: ignore
bargc = plt.barh(bar_positions + bar_width, gc.values, height=bar_width, label='Covid Vaccines', color='b') # type: ignore
bargd = plt.barh(bar_positions + 2 * bar_width, gd.values, height=bar_width, label='Both Vaccines', color='r') # type: ignore
#Adicionar os valores no lado direito das barras
for bars, data in zip([bargg, bargc, bargd], [gg, gc, gd]):
    for bar, value in zip(bars, data.values):
        if(value>0):plt.text(bar.get_width(), bar.get_y() + bar.get_height() /2, str(f'{value}M'),
                 ha='left', va='center', color='black', fontsize=8)
#Dar as labels do gráfico
plt.xlabel('Daily Vaccinations(by the M)')
plt.ylabel('Year-Month')
#Titulo do grafico
plt.title('Daily Vaccination per Month')
plt.yticks(bar_positions + bar_width, date_index.strftime('%m-%y')) # type: ignore
#Meter a numeração simplificada
plt.ticklabel_format(axis='x', style='plain')
#Legenda do grafico
plt.legend()
plt.show()
