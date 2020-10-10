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
data_input= codecs.open("Input.txt", "r","utf-8")
data_text = codecs.open("data.txt","r","utf-8")
data_address = codecs.open("address.txt","r","utf-8")
text = data_input.read()
dtr = data_text.read()
dar = data_address.read()
ck = Cutkum()
cut_words = ck.tokenize(text)
cut_data = ck.tokenize(dtr)
cut_address = ck.tokenize(dar)


#----------Tranformationworks--------
kum = ''
Translation_point = [] #point
Translation_data = []
Translation_address = []
point = 0


for kum in cut_words :
    if data['Informal'].isin([kum]).any(): #check_TranlationWord
        Translation_point.append(point)
    point = point+1

print(Translation_point)
point = 0
for kum in cut_data:
    if data['Informal'].isin([kum]).any():
        Translation_data.append(point)
    point = point + 1
point = 0
for kum in cut_address:
    if data['Informal'].isin([kum]).any():
        Translation_address.append(point)
    point = point + 1

fontword = ''
lastword = ''
for i in Translation_point:
    a = cut_words[i]
    tran_point = 0
    for index in data['Informal'] :
        if a == index:
            cut_words[i] = data.at[tran_point,'Formal']
            if i!= 0:
                fontword = data.at[tran_point,'Frontword']
            lastword = data.at[tran_point,'Lastword']
            break
        tran_point = tran_point+1
    if fontword == cut_words[i-1]:
        cut_words[i-1] = ''
    if i < len(cut_words)-1:
        if lastword == cut_words[i+1]:
            cut_words[i+1] = ''


output_file = codecs.open("Output_cutkum.txt", "w+", "utf-8")
for kum in cut_words :
    output_file.write(kum)
print("END!!")





