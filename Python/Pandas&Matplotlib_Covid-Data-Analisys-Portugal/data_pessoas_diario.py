import pandas as pd
import matplotlib.pyplot as plt
import numpy as np
#Carregar Dados
df=pd.read_csv('vacinas.csv', sep=',')
#Eliminar vazias
df=df.dropna(how='all')
#Eliminar duplicadas
dforiginal=df.drop_duplicates()
#Renomear as colunas
df = df.rename(columns=lambda x: x.strip())
df = df.rename(columns={'data': 'Data'})
#Mudar a data para apenas mes e ano
df['Data']=pd.to_datetime(df['Data'],dayfirst=True)
df['Data'] = df['Data'].dt.strftime('%Y-%m')
#Renomear outras colunas
df = df.rename(columns={'pessoas_vacinadas_completamente_novas': 'Total Daily Vaccination'},)
df = df.rename(columns={'pessoas_vacinadas_parcialmente_novas' : 'Parcial Daily Vaccination'})
df = df.rename(columns={'pessoas_inoculadas_novas' : 'Daily Innoculation'})
df = df.rename(columns={'pessoas_vacinadas_completamente_continente_novas' : 'Total Vaccination(Europe)'})
df = df.rename(columns={'pessoas_reforço_novas' : 'Daily Booster Shot'})
df = df.rename(columns={'pessoas_reforço_continente_novas' : 'Booster Shot(Europe)'})
#Atribuir apenas as colunas necessárias ao estudo, ao dataframe (neste caso as vacinações)
df = df[['Data','Total Daily Vaccination','Parcial Daily Vaccination','Daily Innoculation','Total Vaccination(Europe)','Daily Booster Shot','Booster Shot(Europe)']]
df = df.dropna(how='all', subset=['Total Daily Vaccination','Parcial Daily Vaccination','Daily Innoculation','Total Vaccination(Europe)','Daily Booster Shot','Booster Shot(Europe)'])
#Agrupamentos de dados
gtd=df.groupby(df['Data'].sort_values(ascending=True))['Total Daily Vaccination'].sum()
gpd=df.groupby(df['Data'].sort_values(ascending=True))['Parcial Daily Vaccination'].sum()
gid=df.groupby(df['Data'].sort_values(ascending=True))['Daily Innoculation'].sum()
gtc=df.groupby(df['Data'].sort_values(ascending=True))['Total Vaccination(Europe)'].sum()
grd=df.groupby(df['Data'].sort_values(ascending=True))['Daily Booster Shot'].sum()
grc=df.groupby(df['Data'].sort_values(ascending=True))['Booster Shot(Europe)'].sum()
#Transformação dos valores em milhoes
for g in [gtd, gpd, gid, gtc ,grd, grc]:
        g[:]=round(g/1000000,2)
# Tamanho da barra
bar_height = 0.2
# Transformar datas em posições do eixo y
date_index = pd.to_datetime(grd.index)
# Ordenar as datas/ posições
bar_positions = np.arange(len(date_index))
#Criar barras para cada tipo de agrupamento
bargtd = plt.barh(bar_positions + 1.5 * bar_height, gtd.values, height=bar_height, label='Total Daily Vaccination', color='r') # type: ignore
bargpd = plt.barh(bar_positions + 1 * bar_height, gpd.values, height=bar_height, label='Parcial Daily Vaccination', color='y') # type: ignore
bargid = plt.barh(bar_positions + 0.5 * bar_height , gid.values, height=bar_height, label='Daily Innoculation', color='g') # type: ignore
bargtc = plt.barh(bar_positions - 1.5 * bar_height, gtc.values, height=bar_height, label='Total Vaccination(Europe)', color='b') # type: ignore
bargrd = plt.barh(bar_positions - 1 * bar_height, grd.values, height=bar_height, label='Daily Booster Shot', color='purple') # type: ignore
bargrc = plt.barh(bar_positions - 0.5 * bar_height, grc.values, height=bar_height, label='Booster Shot(Europe)', color='orange') # type: ignore
#Ciclo para meter o texto em cada barra
for bars, data in zip([bargtd,bargpd,bargid,bargtc,bargrd,bargrc], [gtd,gpd,gid,gtc,grd,grc]):
    for bar, value in zip(bars, data.values):
        if (value>0):
            plt.text(bar.get_width() + 0.05, bar.get_y() + bar.get_height() / 2, f'{str(value)}M',
             ha='left', va='center', color='black', fontsize=5.5, rotation=0)
        if (value<0):
            plt.text(bar.get_width() + 0.05, bar.get_y() + bar.get_height() / 2, f'{str(value)}M',
             ha='right', va='center', color='black', fontsize=5.5, rotation=0)
plt.grid(color='black', linestyle='-', linewidth=0.5)
#Labels dos eixos
plt.xlabel('Vaccines')
plt.ylabel('Year-Month')
#Titulo do grafico
plt.title('Vaccination per Month')
#Simplificar a numeração
plt.ticklabel_format(axis='x',style='plain')
plt.yticks(bar_positions+ bar_height, date_index.strftime('%Y-%m')) # type: ignore
#legenda do grafico
plt.legend()
plt.show()
#gravar o ficheiro
df.to_csv('pessoas_diaria.csv', index=False)

