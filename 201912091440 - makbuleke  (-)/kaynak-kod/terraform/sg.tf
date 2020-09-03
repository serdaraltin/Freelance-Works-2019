//data "external" "whatismyip" {
//  program = ["${path.module}/whatismyip.sh"]
//}
//

resource "aws_security_group" "mydb1" {
  name = "mydb1"

  description = "Adventure work sg"
  vpc_id = "${module.adventureworks_vpc.vpc_id}"

  # add new ingress that allow
  # "${data.external.whatismyip.result["internet_ip"]}/32"
  ingress {
    from_port = 3306
    to_port = 3306
    protocol = "tcp"
    cidr_blocks = ["0.0.0.0/0"]
  }

  # Allow all outbound traffic.
  egress {
    from_port = 0
    to_port = 0
    protocol = "-1"
    cidr_blocks = ["0.0.0.0/0"]
  }
}