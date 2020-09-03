# -*- coding: cp1254 -*-
# csv dosyalar�n� okumak i�in
import pandas as pd
import numpy as np
# csv dosyam�z� okuduk.
data = pd.read_csv('iris.csv')

# Ba��ml� De�i�keni ( species) bir de�i�kene atad�k
species = data.iloc[:,-1:].values

# Veri k�memizi test ve train �ekinde b�l�yoruz
from sklearn.cross_validation import train_test_split
x_train, x_test, y_train, y_test = train_test_split(data.iloc[:,1:-1],species,test_size=0.33,random_state=0)


# KNeighborsClassifier s�n�f�n� import ettik
from sklearn.neighbors import KNeighborsClassifier

# KNeighborsClassifier s�n�f�ndan bir nesne �rettik
# n_neighbors : K de�eridir. Bak�lacak eleman say�s�d�r. Default de�eri 5'tir.
# metric : De�erler aras�nda uzakl�k hesaplama form�l�d�r.
# p : Alternatif olarak p parametreside verilir. p de�erini 2 vererek uzakl�k hesaplama form�l�n�
# minkowski yerine �klid olarak de�i�tirebilirsiniz.
knn = KNeighborsClassifier(n_neighbors=5,metric='minkowski')

# Makineyi e�itiyoruz
knn.fit(x_train,y_train.ravel())

# Test veri k�memizi verdik ve iris t�r� tahmin etmesini sa�lad�k
result = knn.predict(x_test)

# Karma��kl�k matrisi
from sklearn.metrics import confusion_matrix
cm = confusion_matrix(y_test,result)
print(cm)

# Ba�ar� Oran�
from sklearn.metrics import accuracy_score
accuracy = accuracy_score(y_test, result)
# Sonu� 
print(accuracy)
