<template>
  <div>
    <form @submit.prevent="submitForm" :action="`/api/Teacher/Edit/${teacherId}`">
      <div class="form-group container">
        <div class="row">
          <div class="col">
            <label for="fullNameArm">Full Name in Armenian</label>
            <input v-model="createData.fullNameArm" type="text" placeholder="Full name in Armenian" name="fullNameArm">
          </div>

          <div class="col">
            <label for="fullNameEng">Full name in English</label>
            <input v-model="createData.fullNameEng" type="text" placeholder="Full name in English" name="fullNameEng">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="professionArm">Profession in Armenian</label>
            <input v-model="createData.professionArm" type="text" placeholder="Profession in Armenian" name="professionArm">
          </div>

          <div class="col">
            <label for="professionEng">Profession in English</label>
            <input v-model="createData.professionEng" type="text" placeholder="Profession in English" name="professionEng">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="descriptionArm">Description in Armenian</label>
            <textarea rows="4" cols="50" v-model="createData.descriptionArm" placeholder="Description in Armenian" name="descriptionArm"></textarea>
          </div>

          <div class="col">
            <label for="descriptionEng">Description in English</label>
            <textarea rows="4" cols="50" v-model="createData.descriptionEng" placeholder="Description in English" name="descriptionEng"></textarea>
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="email">Email</label>
            <input v-model="createData.email" type="email" name="email">
          </div>
          <div class="col">
            <label for="link">Link</label>
            <input v-model="createData.link" type="text" id="link" name="link">
          </div>

        </div>
        <div class="row">
        <div class="col">
          <label for="IsFromLeadership">Leadership</label>
          <input v-model="createData.isFromLeadership" type="checkbox" id="IsFromLeadership" name="IsFromLeadership" checked>
        </div>
        </div>
        <button type="submit" class="thm-btn become-teacher__form-btn">Submit</button>
      </div>
    </form><!-- /.become-teacher__form-content -->
  </div>
</template>

<script>
  import https from 'https';

  export default {
    name: 'EditTeacher',
    data() {
      return {
        teacherId: null,
        createData: { isFromLeadership: false, link: '', fullNameArm: '', fullNameEng: '', email: '', descriptionEng: '', descriptionArm: '', professionArm: '', professionEng: '' },
      };
    },
    async created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }

      // Check if a course ID is provided in the route parameters
      if (this.$route.params.id) {
        this.teacherId = this.$route.params.id;
        await this.fetchTeacherDetails();
      }
    },
    methods: {
      async fetchTeacherDetails() {
        try {
          const response = await this.$axios.get(`/api/TeacherDetails/${this.teacherId}`);
          this.createData = { ...response.data };
        } catch (error) {
          console.error('Error fetching Teacher details:', error);
        }
      },
      async submitForm() {
        try {
          const response = await this.$axios.put(`/api/Teacher/Edit/${this.teacherId}`, this.createData);
          if (response) {
            this.$toasted.success('Edit successful!');
            // Redirect after a successful edit
            window.location = "/admin/teacher/list";
          }
        } catch (error) {
          // Handle error and display message
          this.$toasted.error('An error occurred. Please try again.');
        }
      },
    },
  };
</script>


<style scoped>
  .form-group {
    margin-bottom: 20px;
  }

  .row {
    display: flex;
    justify-content: space-between;
    margin-bottom: 10px;
  }

  .col {
    flex: 0 0 48%; /* Adjust the width as needed */
  }

  label {
    display: block;
    margin-bottom: 5px;
    font-weight: bold;
  }

  input,
  textarea,
  select {
    width: 100%;
    padding: 8px;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box;
    margin-top: 5px;
  }
</style>
