export interface taskDto {
  //update
  id: number;
  title: string;
  description?: string;
  isDone: boolean;
  createdAt: Date;
  updatedAt: Date;
  dueDate: Date; 
}
