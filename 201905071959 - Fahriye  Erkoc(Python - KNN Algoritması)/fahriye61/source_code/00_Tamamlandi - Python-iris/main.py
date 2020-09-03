# -*- coding: cp1254 -*-
import matplotlib.pyplot as plt # gorsellestirme islemleri icin matplotlib 
import pandas as pd # veri seti islemleri icin pandas -> pip install pandas
import seaborn as sns
from pandas.plotting import scatter_matrix
from sklearn import model_selection
from sklearn.discriminant_analysis import LinearDiscriminantAnalysis
from sklearn.linear_model import LogisticRegression
from sklearn.metrics import accuracy_score
from sklearn.metrics import classification_report
from sklearn.metrics import confusion_matrix
from sklearn.naive_bayes import GaussianNB
from sklearn.neighbors import KNeighborsClassifier
from sklearn.svm import SVC
from sklearn.tree import DecisionTreeClassifier


iris_dataset = pd.read_csv("iris.csv") # veri setinin yuklenmesi

X = iris_dataset.values[:, 0:4] # bagimli ve bagimsiz degisken olusturma
Y = iris_dataset.values[:, 4]

# Veri kumesinin egitim ve test verileri olarak ayrilmasi
X_train, X_test, Y_train, Y_test = model_selection.train_test_split(X, Y, test_size=0.20, random_state=7)

print("\n\nVeri setinin icerigi\n") # veri setindeki tum satirlar
print(iris_dataset)

print("\n\nVeri setinin boyutu\n") # veri setinin boyutu
print(iris_dataset.shape)

print("\n\nVeri setinin istatistiksel ozeti\n") # istatiksel ozet
print(iris_dataset.describe())



# kutu grafigi
iris_dataset.plot(kind='box', subplots=True, sharex=False, sharey=False)
plt.show()

# histogram
iris_dataset.hist()
plt.show()

# scatter plot matrix
scatter_matrix(iris_dataset)
plt.show()

svc = SVC()
svc.fit(X_train, Y_train)
predictions = svc.predict(X_test)

print("\n\n")
print("Dogruluk Degeri :", accuracy_score(Y_test, predictions))
print(confusion_matrix(Y_test, predictions))
print(classification_report(Y_test, predictions))
