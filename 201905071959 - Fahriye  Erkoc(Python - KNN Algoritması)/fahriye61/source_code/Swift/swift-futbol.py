// öğrenme verimiz
 
let fenerbahceData:[Int] = [78,60,60,60,74,56,61,70,53,63] // attığı gol sayısı - Fenerbahce
let besiktasData:[Int] = [69,73,75,55,53,63,50,83,60,45] // attığı gol sayısı - Besiktas
let sampiyonlukData:[String] = ["f","b","b","f","f","b","f","b","f","f"]
 
// test verimiz
 
let dataW = 58 // fenerbahce
let dataH = 47 // besiktas
 
func elementCount&lt;Arr:Sequence>(array:Arr,v:Arr.Iterator.Element) -> Int where Arr.Iterator.Element:Equatable {
    
    var count:Int = 0
    
    array.forEach { (val) in
        if v == val {
            count += 1
        }
    }
    
    return count
}
 
// veriler arası uzaklığı bulan fonksiyon
func mesafe(x:Int,y:Int) -> Int {
    
    return abs(x) + abs(y)
    
}
 
func kSet() -> [Int] {
    
    var fbfark:[Int] = []
    var bjkfark:[Int] = []
    var sampiyonData:[Int] = []
    
    for i in 0..&lt;sampiyonlukData.count {
        
        fbfark.insert(dataW - fenerbahceData[i], at: i)
        bjkfark.insert(dataH - besiktasData[i], at: i)
        sampiyonData.insert(mesafe(x: fbfark[i], y: bjkfark[i]), at: i)
        
    }
     return sampiyonData
    
}
 
// algoritmanın yapılacak olan son işlemleri
func kFinal(k:Int) -> String {
    
    let tempkDat = kSet()
    var kDat = kSet().sorted(by: {$0 &lt; $1})
    var f:[String] = []
    
    // bütün indisleri gezme işlemleri
    for i in 0..&lt;k {
        
        let kindis = tempkDat.firstIndex(of: kDat.first!)
        kDat.removeFirst()
        f.insert(sampiyonlukData[kindis!], at: i)
        
    }
    
    // verinin hangi sınıfa ait olduğunu bulduğumuz alan
    if elementCount(array: f, v: "f") > elementCount(array: f, v: "b") {
        return "F"
    } else if elementCount(array: f, v: "f") &lt; elementCount(array: f, v: "b") {
        return "B"
    } else {
        return "nil"
    }
    
}
 
print(kFinal(k: 3)) // F - 3 defa komşuluğa bakıyor ve doğru sonucu buluyor.