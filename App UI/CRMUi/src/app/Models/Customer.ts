import { CustomerOrders } from "./CustomerOrders"
import { CustomerAddress } from "./CustomerAddress"
export class Customer {
    id: number = 0
    code: string = ""
    firstName: string = ""
    lastName: string = ""
    email: string = ""
    phone: number = 0
    customerAddress: CustomerAddress[] = []
    customeroder: CustomerOrders[] = []
}