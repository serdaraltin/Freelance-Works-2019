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
//BU KISIM ÝLERÝDE PARENTS VE CHÝLDS VEKTÖRLERÝNDEKÝ ELEMANLARI YAZDIRMAK ÝÇÝNYAZILMIÞ BÝR FONSÝYON
void print(std::vector<int> const &input)
{
 for (int i = 0; i < input.size(); i++) {
 EV << input.at(i) << ' ';
 }
}
//HER NODE'UN BAÞLANGIÇTA SAHÝP OLACAÐI NÝTEKLÝKLERÝ INITIALIZE ETTÝÐÝMÝZ YER
//AYRICA PROGRAMIN BAÞLANGIÇ NOKTASINI getIndex() KISMINDA SEÇÝYORUZ
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
//Ýþlerin neredeyse tamamýnýn yapýldýðý handleMessage kýsmý.
void Node::handleMessage(cMessage *msg)
{
 //gelen mesaj baþlangýç ise tüm komþu noktalara kontrol etmeksizin probe mesajý gönderiyoruz.
 if(strcmp("baslangic", msg->getName()) == 0 ){
 int n = gateSize("g");
 for (int i = 0; i < n; i++)
 {
 probe = new cMessage("probe");
 send(probe, "g$o", i);
 }
 }
 // Gelen mesaj probe mesajý ise öncelikle daha önce parent var mý diye kontrol ediyoruz.
 // Eðer parent yoksa mesajýn geldiði yerin id'sini parentsa iletiyoruz ve gelen yere
 // bir adet ack mesajý, gelen yer hariç diðer tüm noktalara probe mesajý gönderiyoruz.
 // Eðer daha önce bir parent varsa mesajýn geldiði yere reject mesajý gönderiyoruz
 else if (strcmp("probe", msg->getName()) == 0 ) {
 if(parents.empty() == true){
 parents.push_back(msg->getSenderModuleId());
 EV << "parents = " ;
 print(parents);
 // Mesajýn geldiði yere ack mesajý yolladýðýmýz kýsým
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
 // Mesajýn geldiði yere ack mesajý yolladýðýmýz kýsým
 // Mesajýn geldiði yer hariç her yere probe mesajý yolladýðýmzý kýsým
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
 // Mesajýn geldiði yer hariç her yere probe mesajý yolladýðýmzý kýsým
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

 //Eðer bir mesaj probe yada reject deðilse ack'týr
 // Ack mesajý alan bir nokta mesajýn geldiði yeri çocuðu olarak iþaretler.
 else if(strcmp("act", msg->getName()) == 0) {
 childs.push_back(msg->getSenderModuleId());
 EV << "childs = " ;
 print(childs);
 }
}
//Mesaj gönderme dahil tüm iþlemleri handleMessage kýsmýnda yaptýðým için bu kýsýma birþey yazma gereði duymadým.
void Node::forwardMessage(cMessage *msg){
}
