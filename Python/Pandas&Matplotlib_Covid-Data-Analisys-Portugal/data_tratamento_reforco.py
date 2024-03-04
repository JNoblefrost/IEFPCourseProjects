import pandas as pd
import matplotlib.pyplot as plt
import numpy as np
# Carregar informação do ficheiro
df = pd.read_csv('vacinas_refoco_diaria.csv', sep=',')
# Agrupamento de dados que queremos ver
f1 = df['80+'].sum()
f2 = df['70-79'].sum()
f3 = df['60-69'].sum()
f4 = df['50-59'].sum()
f5 = df['40-49'].sum()
f6 = df['30-39'].sum()
f7 = df['18-29'].sum()


# Array de dados(com os valores absolutos de forma a inverter a percentagem no gráfico de tarte)
valores_absolutos = np.array([f1,f2,f3,f4,f5,f6,f7])
# Função para redefinir os valores percentuais do parametro "autopct" do .pie(), de forma a tomarem os seus valores absolutos ao invés de percentagens
def absolute_value(val):
    a  = np.round(val/100.*valores_absolutos.sum(), 0)
    return a
# Lista com os dados absolutos
p1f =[f1,f2,f3,f4,f5,f6,f7]
# Lista com os etiquetas da legenda e no gráfico
labelsAge = ["80+","70-79","60-69","50-59","40-49","30-39","18-29"]
# Lista de cores de cada fatia do gráfico
#slicesColours = ["#f9e5f1","#f4cce3","#eeb2d5","#e999c8","#e47fba","#de66ac","#d94c9f"]
slicesColours = ["#d94c9f","#de66ac","#e47fba","#e999c8","#eeb2d5","#f4cce3","#f9e5f1"]
#Array de valores da extrusão pelo parâmetro "explode"
explodeSlice = [0.03,0.03,0.03,0.05,0.03,0.03,0.03]
plt.figure( dpi=80)
# Designação do gráfico em tarte
pp1f=plt.pie(p1f,startangle=90, labels=labelsAge,colors=slicesColours,autopct=absolute_value, wedgeprops={"edgecolor":"k",'linewidth': 1, 'antialiased': True},explode=explodeSlice)
#Título do gráfico
plt.title('Booster shots per Age Group')
# Definições da label
plt.ticklabel_format(axis='x', style='plain')
plt.legend(title="Ages",loc='lower right')
plt.show()
