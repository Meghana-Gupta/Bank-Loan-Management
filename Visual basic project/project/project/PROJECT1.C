#include<stdio.h>
#include<conio.h>
static int k;
struct hospital
{
	char HospiID[30];
	char HospiName[70];
	char HospiAdd[70];
	char PhoneNo[15];
	char MailId[70];
	char Speciality[70];
	struct hospital *next;
}*s;

struct doctor
{
	char HospiID[20];
	char DocID[20];
	char DocName[70];
	char DocSpecialization[70];
	char DocYears[10];
	struct doctor *next;
}*d;

struct node
{
	int val;
	struct hospital *next;
}index[26];

struct node1
{
	int val;
	struct doctor *next;
}index1[26];

void search();

void main()
{
	int i;
	int ch;
	clrscr();
//	inc=(char *)malloc(sizeof(char));
//while(1)
//{
	printf("\n\n\t\tWelcome to HEALTH CARE\n\t(You can search the hospital and doctors\n\t     based on your income & problem:)\n\n\n");
	for(i=0;i<26;i++)
	{
		index[i].val=i;
		index1[i].val=i;
		index[i].next=NULL;
		index1[i].next=NULL;
	}
	do
	{
		search();
		printf("\n\nWant to search another hospital & doctor:y/n");
		scanf("%d",&ch);
		//if(ch==0)
		  //	break;
	}while(ch!=0);
	printf("\n\nThank you for using our service!!!");
	printf("\n\n\tRunTime:%d",k);
	getch();
}

void search()
{
	FILE *fp,*fp1,*fp2,*fp3,*fp4;
	int temp,j=0,i,entry;
	char ch,name[50],phoneNo[12],emailID[50],email[70],inc1[1];
	int inc,other;
	struct hospital *ptr;
	struct doctor *ptr1;
	char prob[50],hosID[10];
	double income;
	printf("\n\nAre you an already existing user?yes=1/no=0");
	printf("\n(If Yes, you must provide your Email ID to sign in.\nIf you are a new user please type '0' and provide the required details:)");
	printf("\n Now select the choice:");
	scanf("%d",&entry);
	if(entry==0)
	{
		fp3=fopen("user.c","a");
		printf("Enter your name:");
		scanf("%s",name);
		printf("Enter your phone no.:");
		scanf("%s",phoneNo);
		printf("Enter your email id:");
		scanf("%s",emailID);
		printf("Enter your income:");
		scanf("%lf",&income);
		fprintf(fp3,"%s %s %s %lf ",name,phoneNo,emailID,income);
		j=1;
	}
	else if(entry==1)
	{
		printf("Enter your email id:");
		scanf("%s",email);
		fp4=fopen("user.c","r");
		while(fscanf(fp4,"%s%s%s%lf%s%s",name,phoneNo,emailID,&income,prob,hosID)!=EOF)
		{
			if(strcmp(emailID,email)==0)
			{
				j=1;
				break;
			}
		}
	}
	if(j==0)
	{
		printf("It seems that you forgot your given email id!");
		getch();
		return;
	}

	printf("%s\n%s\n%s\n%lf\n\n",name,phoneNo,emailID,income);
	printf("Enter your problem:\n\tCardiology\n\tOrthopedics\n\tDiabetology\n\tNeurology\n\tGeneral_Surgery\n\tENT\n\tPediatrics\n\tPlastic_Surgery:\n\n");
	scanf("%s",prob);

	if(income<=250000)
		fp=fopen("HOSPI1.C","r");
	else if(income>250000 && income<=500000)
		fp=fopen("HOSPI2.C","r");
	else if(income>500000)
		fp=fopen("HOSPI3.C","r");

//	fp1=fopen("out.c","w");
	s=(struct hospital *)malloc(sizeof(struct hospital));
	fscanf(fp,"%s%s%s%s%s%s",s->HospiID,s->HospiName,s->HospiAdd,s->PhoneNo,s->MailId,s->Speciality);
	s=(struct hospital *)malloc(sizeof(struct hospital));
	while(fscanf(fp,"%s%s%s%s%s%s",s->HospiID,s->HospiName,s->HospiAdd,s->PhoneNo,s->MailId,s->Speciality)!=EOF)
	{
		k=k+2;
//		fprintf(fp1,"%s %s %s %s %s %s\n",s->HospiID,s->HospiName,s->HospiAdd,s->PhoneNo,s->MailId,s->Speciality);
		if(strcmp(prob,s->Speciality)==0)
		{

			s->next=NULL;
			ch=s->HospiName[0];
			temp=ch%26;
			if(index[temp].next==NULL)
				index[temp].next=s;
			else
			{
				ptr=index[temp].next;
				while(ptr->next!=NULL)
				{
					ptr=ptr->next;
					k++;
				}
				ptr->next=s;
			}
		}
			s=(struct hospital *)malloc(sizeof(struct hospital));
	}
	fp1=fopen("out.c","w");
	for(i=0;i<26;i++)
	{
		if(index[i].next!=NULL)
		{
			ptr=index[i].next;
			while(ptr!=NULL)
			{
				printf("%s\n %s\n %s\n %s\n %s\n\n",ptr->HospiID,ptr->HospiName,ptr->HospiAdd,ptr->PhoneNo,ptr->MailId);
				fprintf(fp1,"%s %s %s %s %s\n",ptr->HospiID,ptr->HospiName,ptr->HospiAdd,ptr->PhoneNo,ptr->MailId);
				ptr=ptr->next;
			}
			printf("\n");
		}
	}
	fp2=fopen("DOCTOR.C","r");
	printf("Enter the hospital id:");
	scanf("%s",hosID);
	do
	{
	rewind(fp2);
	d=(struct doctor *)malloc(sizeof(struct doctor));
	fscanf(fp2,"%s%s%s%s%s",d->HospiID,d->DocID,d->DocName,d->DocSpecialization,d->DocYears);
	d=(struct doctor *)malloc(sizeof(struct doctor));
	for(i=0;i<26;i++)
	{
		while(fscanf(fp2,"%s%s%s%s%s",d->HospiID,d->DocID,d->DocName,d->DocSpecialization,d->DocYears)!=EOF)
		{
			k=k+2;
			if(strcmp(d->HospiID,hosID)==0)
			{
				d->next=NULL;
				ch=s->HospiID[0];
				temp=ch%26;
				if(index1[temp].next==NULL)
					index1[temp].next=d;
				else
				{
					ptr1=index1[temp].next;
					while(ptr1->next!=NULL)
					{
						ptr1=ptr1->next;
						k++;
					}
					ptr1->next=d;
				}
			}
			d=(struct doctor *)malloc(sizeof(struct doctor));
		}
	}
	for(i=0;i<26;i++)
	{
		if(index1[i].next!=NULL)
		{
			ptr1=index1[i].next;
			while(ptr1!=NULL)
			{
				printf("HosID:%s\n DoctorID:%s\n DoctorName:%s\n years of experience:%s\n\n",ptr1->HospiID,ptr1->DocID,ptr1->DocName,ptr1->DocYears);
				fprintf(fp1,"%s %s %s %s\n",ptr1->HospiID,ptr1->DocID,ptr1->DocName,ptr1->DocYears);
				ptr1=ptr1->next;
			}
			printf("\n");
		}
	}
	printf("\n\nWant to refer doctors from another hospitals for your problem:yes=1/no=0\nEnter your choice:");
	scanf("%d",&other);
	if(other!=0)
	{
		printf("Enter the hospital id:");
		scanf("%s",hosID);
	}
	}while(other!=0);
	if(entry==0)
		fprintf(fp3,"%s %s\n",prob,hosID);
	printf("\n\n\nWant to fix an appointment?yes=1/no=0");
	scanf("%d",&inc);

	if(inc==1)
		printf("\tYour request had been sent:)!!!");
	else
		printf("\tThank you!");
	fcloseall();
	free(ptr);
	free(ptr1);
}