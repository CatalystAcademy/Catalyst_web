<template>
  <div>
    <form @submit.prevent="submitForm">
      <div class="form-group container">
        <div class="row">
          <div class="col">
            <label for="fullNameArm">Full Name in Armenian</label>
            <input v-model="createData.fullNameArm" type="text" id="fullNameArm" placeholder="Full name in Armenian" name="fullNameArm">
          </div>

          <div class="col">
            <label for="fullNameEng">Full name in English</label>
            <input v-model="createData.fullNameEng" type="text" id="fullNameEng" placeholder="Full name in English" name="fullNameEng">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="positionArm">Position in Armenian</label>
            <input v-model="createData.positionArm" type="text" id="positionArm" placeholder="Position in Armenian" name="positionArm">
          </div>

          <div class="col">
            <label for="positionEng">Position in English</label>
            <input v-model="createData.positionEng" type="text" id="positionEng" placeholder="Position in English" name="positionEng">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="textArm">Text in Armenian</label>
            <textarea rows="4" cols="50" v-model="createData.textArm" id="textArm" placeholder="Text in Armenian" name="textArm"></textarea>
          </div>

          <div class="col">
            <label for="textEng">Text in English</label>
            <textarea rows="4" cols="50" v-model="createData.textEng" id="textEng" placeholder="Text in English" name="textEng"></textarea>
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
        testimonialId: null,
        createData: { fullNameArm: '', fullNameEng: '', positionArm: '', positionEng: '', textArm: '', textEng: '' },
      };
    },
    async created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }

      // Check if a course ID is provided in the route parameters
      if (this.$route.params.id) {
        this.testimonialId = this.$route.params.id;
        await this.fetchTeacherDetails();
      }
    },
    methods: {
      async fetchTeacherDetails() {
        try {
          const response = await this.$axios.get(`/api/TestimonialDetails/${this.testimonialId}`);
          this.createData = { ...response.data };
        } catch (error) {
          console.error('Error fetching Testimonial details:', error);
        }
      },
      async submitForm() {
        try {
          const response = await this.$axios.put(`/api/Testimonial/Edit/${this.testimonialId}`, this.createData);
          if (response) {
            this.$toasted.success('Edit successful!');
            // Redirect after a successful edit
            window.location = "/admin/testimonial/list";
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
