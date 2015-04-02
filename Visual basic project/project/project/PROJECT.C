#include<stdio.h>
#include<conio.h>

struct hospital
{
	char HospiID[5];
	char HospiName[50];
	char HospiAdd[70];
	char PhoneNo[15];
	char MailId[50];
	char Speciality[30];
	struct hospital *next;
}*s;

struct doctor
{
	char HospiID[5];
	char DocID[5];
	char DocName[50];
	char DocSpecialization[50];
	char DocYears[3];
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

char prob[20],hosID[5];

void main()
{
	FILE *fp,*fp1,*fp2;
	int i,temp;
	char ch;
	struct hospital *ptr;
	struct doctor *ptr1;
	clrscr();

	for(i=0;i<26;i++)
	{
		index[i].val=i;
		index1[i].val=i;
		index[i].next=NULL;
		index1[i].next=NULL;
	}
	printf("Enter your problem:");
	scanf("%s",prob);

	fp=fopen("HOSPI1.C","r");

	s=(struct hospital *)malloc(sizeof(struct hospital));
	fscanf(fp,"%s%s%s%s%s%s",s->HospiID,s->HospiName,s->HospiAdd,s->PhoneNo,s->MailId,s->Speciality);
	s=(struct hospital *)malloc(sizeof(struct hospital));
	while(fscanf(fp,"%s%s%s%s%s%s",s->HospiID,s->HospiName,s->HospiAdd,s->PhoneNo,s->MailId,s->Speciality)!=EOF)
	{
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
					ptr=ptr->next;
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
	printf("Enter the hospital id:");
	scanf("%s",hosID);


	fp2=fopen("DOCTOR.C","r");
	d=(struct doctor *)malloc(sizeof(struct doctor));
	fscanf(fp2,"%s%s%s%s%s",d->HospiID,d->DocID,d->DocName,d->DocSpecialization,d->DocYears);
	d=(struct doctor *)malloc(sizeof(struct doctor));
	for(i=0;i<26;i++)
	{
		while(fscanf(fp2,"%s%s%s%s%s",d->HospiID,d->DocID,d->DocName,d->DocSpecialization,d->DocYears)!=EOF)
		{
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
						ptr1=ptr1->next;
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
				printf("%s\n %s\n %s\n %s\n %s\n\n",ptr1->HospiID,ptr1->DocID,ptr1->DocName,ptr1->DocSpecialization,ptr1->DocYears);
				fprintf(fp1,"%s %s %s %s %s\n",ptr1->HospiID,ptr1->DocID,ptr1->DocName,ptr1->DocSpecialization,ptr1->DocYears);
				ptr1=ptr1->next;
			}
			printf("\n");
		}
	}
	fcloseall();
	getch();
}