
#include <iostream>
#include <fstream>


#define MAXROWS 10
#define MAXCOLS 10
#define MAXSIZE 20

using namespace std;

//prototip olusturma
class Matrix
{
    public:
        Matrix(); //bos matris prototip
        Matrix(float data[MAXROWS][MAXCOLS], int rows, int cols); // float dizi[][],int satirlar, int kolonlar
        void print(void);
        Matrix operator+(const Matrix &); 
        Matrix operator+(float scalar_value);
        void operator++(void);
        void operator+=(const Matrix &);
    private:
        int rows;
        int cols;
        float data[MAXROWS][MAXCOLS]; //ikiye ikilik float veri tipindeki dizi
        bool test_stochastic(void);
};

int main(int argc, char *argv[])
{

    //degisken deklarasyonu
    int i, j , k, rows, cols, size;
    float data[MAXROWS][MAXCOLS]; 
    Matrix Mat[MAXSIZE]; 
    Matrix Result1, Result2;

    ifstream file("matris.txt");//matris dosyasi varlik kontrolu
    if (!file.is_open()){//dosyanin okunabilirlik durumunun kontrol edilmesi
        cout << "Dosya acilamadi." << endl;
        return 0;//dosya okunamassa islemin sonlandirilmasi
    }

    //matris dosyasi icerik okuma
    for (k = 0; !file.eof(); k++){
        file >> rows;
        file >> cols;

        //iki boyutlu dizi icerisinde ic ice dongu yaparak deger atama
        for (i = 0; i < rows; i++){
            for (j = 0; j < cols; j++){
                file >> data[i][j];
            }
        }
        Mat[k] = Matrix(data, rows, cols); 
    }

    size = k;
    file.close(); //dosya ile islemlerin tamamlanmasi sonucu dosya baglantisinin kapatilmasi

    cout << "Sonuc Matrisi" << endl; 
    Result2 = Mat[4] + 70;
    Result2.print(); 

    //diger islemler
    ++Mat[2]; // isleme almadan once dizinin degerini arttirma
    Mat[3] += Mat[1];

    //
    for(k = 0; k < size; k++){ // her bir matrisi donerek ekrana yazma
        cout << endl << "___________" << endl << "Matris #" << k << " |" << endl << "________________________________" << endl;
        Mat[k].print();
    }

    //
    cout << "Cikis yapmak icin Enter'a basiniz..." << endl;
    int ch = cin.get();
    return 0;

}


// OOP konseptlerinden overloading(asiri yukleme) yaparak parametresiz matris yapici
Matrix::Matrix()
{
    int i, j;
    for(i=0; i < MAXROWS; i++){
        for(j = 0; j < MAXCOLS; j++){
            data[i][j] = 0; //parametresiz matris icin matrisi sıfırlama
        }
    }


}

// OOP konseptlerinden overloading(asiri yukleme) yaparak parametreli matris yapici
Matrix::Matrix(float data[MAXROWS][MAXCOLS], int rows, int cols){
    this->rows = rows;
    this->cols = cols;

    int i, j;
    //ic ice dongu yaparak fonksiyona giren her bir degeri karsilik geldigi matris degerine atama
    for(i = 0; i < rows; i++){
        for(j = 0; j < cols; j++){
            this->data[i][j] = data[i][j];
        }
    }
}


bool Matrix::test_stochastic(void) 
{
    if(rows != cols){
        return false; //stokastik olma durumunun kontrolunde sonuc dondurme
    }

    int i, j;
    float sum;
    //verinin stokastik olma durumunu her bir elamaninda gezerek gereken kosulun saglanmasi kontrolu
    for(i = 0; i < rows; i++){
        for(j = 0, sum = 0; j < cols; j++){
            if(data[i][j] < 0){
                return false; //matrisin stokastik olmasi durumunda donulen deger true
            }
            sum += data[i][j];
        }

        if(sum != 1.0){
            return false;//matrisin stokastik olmamasi durumunda donulen deger true
        }

        return true;//matrisin stokastik olmasi durumunda donulen deger true
    }
}


void Matrix::print(void)
{
    int i, j;
    for(i = 0; i < rows; i++){
        for(j = 0; j < cols; j++){
            cout << data[i][j] << " ";// matrisin her bir elemanini donerek aralarinda bir bosluk olacak sekilde ekrana yazma
        }
        cout << endl;
    }

    if(test_stochastic()){//fonksiyondan true deger geliyorsa matrisin tipini ekrana yazma
        cout << "Bu matris stokastiktir(degisken)"  << endl;
    }
}


Matrix Matrix::operator+(const Matrix& b)
{
    if(this->rows != b.rows || this->cols != b.cols){
        cout << "Boyut esitsizligi oldugundan islem yapilamaz." << endl; 
        //parametre olarak gelen deger ile paylasimsiz ana degiskendeki iki degerden biri esitligi bozarsa
        return *this;
    }

    float data_new[MAXROWS][MAXCOLS]; //yeni bir ikiye ikilik matris olusturma
    int i, j;
    
    //ic ice dongu ile yeni olusturulan matrise parametreden gelen veriyi ve ana degiskendeki veriyi ust uste ekleme
    for(i = 0; i < rows; i++){
        for(j = 0; j < cols; j++){
            data_new[i][j] = data[i][j] + b.data[i][j];
        }
    }

    return Matrix(data_new, rows, cols); // recursive(ozyineli) fonksiyon
    //fonksiyonun kendini cagirmasi ve yeni olusturulan matrisi kendi kopyasinda isleme uzere parametre olarak gonderme

}


Matrix Matrix::operator+(float scalar_value)
{
    float data_new[MAXROWS][MAXCOLS];
    int i, j;
    //ic ice dongu verinin her bir elemanina +1 ekleme
    for(i = 0; i < rows; i++){
        for(j = 0; j < cols; j++){
            this->data[i][j] += 1; //ana sinif icerisindeki dizenin her bir elemanini gezerek degerini 1 arttirma
        }
    }
}

void Matrix::operator++(void)
{
    int i, j;
    //ic ice dongu verinin her bir elemanina +1 ekleme
    for(i = 0; i < rows; i++){
        for(j = 0; j < cols; j ++){
            this->data[i][j] += 1;
        }
    }
}

void Matrix::operator+=(const Matrix& b)
{
    if(this->rows != rows || this->cols != cols){
       cout << "Boyut esitsizligi oldugundan islem yapilamaz." << endl;
       //parametre olarak gelen deger ile paylasimsiz ana degiskendeki iki degerden biri esitligi bozarsa
        return;
    }

    int i, j;
    //ic ice dongu ile yeni olusturulan matrise parametreden gelen veriyi ve ana degiskendeki veriyi ust uste ekleme
       for(i = 0; i < rows; i++){
        for(j = 0; j < cols; j++){
            this->data[i][j] += b.data[i][j];
        }
    }
}
