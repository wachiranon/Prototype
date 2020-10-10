import deepcut
import codecs
import xlrd
import pandas as pd
import csv
from cutkum.tokenizer import Cutkum


#------opendatabase------
loc_db = (r"formalword.csv")
data = pd.read_csv(loc_db)


#------readfile-------
f= codecs.open("Input.txt", "r","utf-8")
text = f.read()
ck = Cutkum()
#cut_words = ck.tokenize(text)
deepcut_words = deepcut.tokenize(text)


#----------Tranformationworks--------
#row = sheet.nrows
data.dropna(inplace = True)
kum = ''
Translation_point = [] #point
Translation_Word = []
point = 0



for kum in deepcut_words :
    if data['Informal'].isin([kum]).any(): #check_TranlationWord
        Translation_point.append(point)
    point = point+1

print(Translation_point)

fontword = ''
lastword = ''
for i in Translation_point:
    #a = deepcut_words[i]
    tran_point = 0
    for index in data['Informal'] :
        if deepcut_words[i] == index:
            print(i)
            deepcut_words[i] = data.at[tran_point,'Formal']
            print(data.at[tran_point,'CodeNumber'])
            if i!= 0:
                fontword = data.at[tran_point,'Frontword']
            lastword = data.at[tran_point,'Lastword']
            break
        tran_point = tran_point+1
        print(tran_point)
    if fontword == deepcut_words[i-1]:
        deepcut_words[i-1] = ''
    if lastword == deepcut_words[i+1]:
        if lastword == deepcut_words[i+1]:
            deepcut_words[i+1] = ''

output_file = codecs.open("Output_deepcut.txt", "w+", "utf-8")
for kum in deepcut_words :
    output_file.write(kum)

print("END!!")




