#include <string.h>
#include <omnetpp.h>
#include <string>
#include <stdio.h>
#include <vector>
#include <algorithm>
using namespace omnetpp;
class Node : public cSimpleModule
{
private:
 cMessage *probe;
 cMessage *act;
 cMessage *reject;
 cMessage *baslangic;
 std::vector<int> parents;
 std::vector<int> childs;
 // std::vector<int>::iterator it;
protected:
 virtual void initialize() override;
 virtual void handleMessage(cMessage *msg) override;
 virtual void forwardMessage(cMessage *msg);
};
Define_Module(Node);
//BU KISIM �LER�DE PARENTS VE CH�LDS VEKT�RLER�NDEK� ELEMANLARI YAZDIRMAK ���NYAZILMI� B�R FONS�YON
void print(std::vector<int> const &input)
{
 for (int i = 0; i < input.size(); i++) {
 EV << input.at(i) << ' ';
 }
}
//HER NODE'UN BA�LANGI�TA SAH�P OLACA�I N�TEKL�KLER� INITIALIZE ETT���M�Z YER
//AYRICA PROGRAMIN BA�LANGI� NOKTASINI getIndex() KISMINDA SE��YORUZ
void Node::initialize()
{
 std::vector<int> parents;
 std::vector<int> childs;
 // std::vector<int>::iterator it;
 if (getIndex() == 0) {
 baslangic = new cMessage("baslangic");
 EV << "Program baslayacak \n";
 scheduleAt(0.0, baslangic);
 }
}
//��lerin neredeyse tamam�n�n yap�ld��� handleMessage k�sm�.
void Node::handleMessage(cMessage *msg)
{
 //gelen mesaj ba�lang�� ise t�m kom�u noktalara kontrol etmeksizin probe mesaj� g�nderiyoruz.
 if(strcmp("baslangic", msg->getName()) == 0 ){
 int n = gateSize("g");
 for (int i = 0; i < n; i++)
 {
 probe = new cMessage("probe");
 send(probe, "g$o", i);
 }
 }
 // Gelen mesaj probe mesaj� ise �ncelikle daha �nce parent var m� diye kontrol ediyoruz.
 // E�er parent yoksa mesaj�n geldi�i yerin id'sini parentsa iletiyoruz ve gelen yere
 // bir adet ack mesaj�, gelen yer hari� di�er t�m noktalara probe mesaj� g�nderiyoruz.
 // E�er daha �nce bir parent varsa mesaj�n geldi�i yere reject mesaj� g�nderiyoruz
 else if (strcmp("probe", msg->getName()) == 0 ) {
 if(parents.empty() == true){
 parents.push_back(msg->getSenderModuleId());
 EV << "parents = " ;
 print(parents);
 // Mesaj�n geldi�i yere ack mesaj� yollad���m�z k�s�m
 cGate * sender = msg->getSenderGate();
 for (cModule::GateIterator i(this); !i.end(); i++)
 {
 cGate *gate = i();
 std::string gateStr = gate->getName();
 if (gateStr == "g$o" && gate->getPathEndGate()->getOwnerModule()
== sender->getOwnerModule() )
 {
 int senderId = gate->getIndex();
 act = new cMessage("act");
 send(act, "g$o", senderId);
 }
 }
 // Mesaj�n geldi�i yere ack mesaj� yollad���m�z k�s�m
 // Mesaj�n geldi�i yer hari� her yere probe mesaj� yollad���mz� k�s�m
 for (cModule::GateIterator i(this); !i.end(); i++)
 {
 cGate *gate = i();
 std::string gateStr = gate->getName();
 if (gateStr == "g$o" && gate->getPathEndGate()->getOwnerModule()
== sender->getOwnerModule() )
 {
 int senderId = gate->getIndex();
 int n = gateSize("g");
 for (int i = 0; i < n; i++)
 {
 if( i == senderId){
 }
 else{probe = new cMessage("probe");
 send(probe, "g$o", i);
 }
 }
 }
 }
 // Mesaj�n geldi�i yer hari� her yere probe mesaj� yollad���mz� k�s�m
 }
 else {
 cGate * sender = msg->getSenderGate();
 for (cModule::GateIterator i(this); !i.end(); i++)
 {
 cGate *gate = i();
 std::string gateStr = gate->getName();
 if (gateStr == "g$o" && gate->getPathEndGate()->getOwnerModule()
== sender->getOwnerModule() )
 {
 int senderId = gate->getIndex();
 reject = new cMessage("reject");
 send(reject, "g$o", senderId);
 }
 }
 }
 }

 //E�er bir mesaj probe yada reject de�ilse ack't�r
 // Ack mesaj� alan bir nokta mesaj�n geldi�i yeri �ocu�u olarak i�aretler.
 else if(strcmp("act", msg->getName()) == 0) {
 childs.push_back(msg->getSenderModuleId());
 EV << "childs = " ;
 print(childs);
 }
}
//Mesaj g�nderme dahil t�m i�lemleri handleMessage k�sm�nda yapt���m i�in bu k�s�ma bir�ey yazma gere�i duymad�m.
void Node::forwardMessage(cMessage *msg){
}
