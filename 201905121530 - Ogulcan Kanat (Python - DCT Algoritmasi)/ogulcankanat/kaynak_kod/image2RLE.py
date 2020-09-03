import cv2
import numpy as np
import math


from zigzag import *
#zigzag icerisindeki fonksiyonlari ice aktarma


def get_run_length_encoding(image):
    i = 0
    skip = 0
    stream = []    
    bitstream = ""
    image = image.astype(int)
    while i < image.shape[0]:
        if image[i] != 0:            
            stream.append((image[i],skip))
            bitstream = bitstream + str(image[i])+ " " +str(skip)+ " "
            skip = 0
        else:
            skip = skip + 1
        i = i + 1

    return bitstream

#blok boyutu tanimlama
block_size = 8



#Niceleme Matrisi
QUANTIZATION_MAT = np.array([[16,11,10,16,24,40,51,61],[12,12,14,19,26,58,60,55],[14,13,16,24,40,57,69,56 ],[14,17,22,29,51,87,80,62],[18,22,37,56,68,109,103,77],[24,35,55,64,81,104,113,92],[49,64,78,87,103,121,120,101],[72,92,95,98,112,100,103,99]])



#okunan goruntuyu gri tonlanmis yapma
img = cv2.imread('harry.jpg', cv2.IMREAD_GRAYSCALE)



#goruntunun boyutunu alma
[h , w] = img.shape




#gerekli blok sayisini hesaplama
height = h
width = w
h = np.float32(h) 
w = np.float32(w) 

nbh = math.ceil(h/block_size)
nbh = np.int32(nbh)

nbw = math.ceil(w/block_size)
nbw = np.int32(nbw)


#pad iceren goruntu yuksekligi
H =  block_size * nbh

#pad iceren goruntu genisligi
W =  block_size * nbw


#H,W boyutunda bir matris olusturma(numpy)
padded_img = np.zeros((H,W))



padded_img[0:height,0:width] = img[0:height,0:width]

cv2.imwrite('sikistirilmamis.bmp', np.uint8(padded_img))





for i in range(nbh):
    
        # Blogun baslangic ve bitis satir index degerlerini hesaplama
        row_ind_1 = i*block_size                
        row_ind_2 = row_ind_1+block_size
        
        for j in range(nbw):
            
            # Blogun baslangic ve bitis sutun index degerlerini hesaplama
            col_ind_1 = j*block_size                       
            col_ind_2 = col_ind_1+block_size
                        
            block = padded_img[ row_ind_1 : row_ind_2 , col_ind_1 : col_ind_2 ]
                       
            #Secili bloga 2B ayrik kosinus degisimi uygulama                      
            DCT = cv2.dct(block)            

            DCT_normalized = np.divide(DCT,QUANTIZATION_MAT).astype(int)            
            
            # DCT katsayilarini siralama
            # tek boyutlu bir dizi dondurulecektir
            reordered = zigzag(DCT_normalized)

            #blok boyutuna gore diziyi tekrar sekillendirir
            reshaped= np.reshape(reordered, (block_size, block_size)) 
            
            
            padded_img[row_ind_1 : row_ind_2 , col_ind_1 : col_ind_2] = reshaped                        

cv2.imshow('encoded image', np.uint8(padded_img))

arranged = padded_img.flatten()



bitstream = get_run_length_encoding(arranged)

#Goruntu olusturmak icin gelen verileri ";" ile ayirma
bitstream = str(padded_img.shape[0]) + " " + str(padded_img.shape[1]) + " " + bitstream + ";"

#veriyi metin dosyasina yazma
file1 = open("veri.txt","w")
file1.write(bitstream)
file1.close()

cv2.waitKey(0)
cv2.destroyAllWindows()




