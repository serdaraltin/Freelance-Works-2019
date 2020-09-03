module "adventureworks_vpc" {
  // https://registry.terraform.io/modules/terraform-aws-modules/vpc/aws/1.30.0
  source  = "terraform-aws-modules/vpc/aws"
  version = "1.30.0"

  name = "adventureworks-vpc"

  cidr = "10.200.0.0/16"

azs = ["${var.aws_region}a", "${var.aws_region}b", "${var.aws_region}c"]

  private_subnets = ["10.200.103.0/24"]
  public_subnets  = ["10.200.1.0/24", "10.200.101.0/24"]

  enable_dns_hostnames = true

}