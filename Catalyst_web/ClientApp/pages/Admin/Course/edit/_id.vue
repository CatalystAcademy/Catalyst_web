<template>
  <div>
    <form @submit.prevent="submitForm" :action="`/api/Courses/Edit/${courseId}`">
      <div class="form-group container">
        <div class="row">
          <div class="col">
            <label for="titleArm">Title in Armenian</label>
            <input v-model="createData.titleArm" type="text" placeholder="Title in Armenian" name="titleArm">
          </div>

          <div class="col">
            <label for="titleEng">Title in English</label>
            <input v-model="createData.titleEng" type="text" placeholder="Title in English" name="titleEng">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="instractorArm">Instractor Full Name in Armenian</label>
            <input v-model="createData.instractorArm" type="text" placeholder="Instractor Full Name in Armenian" name="instractorArm">
          </div>

          <div class="col">
            <label for="instractorEng">Title in English</label>
            <input v-model="createData.instractorEng" type="text" placeholder="Instractor Full Name in English" name="instractorEng">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="descriptionArm">Description in Armenian</label>
            <textarea rows="4" cols="50" v-model="createData.descriptionArm" type="text" placeholder="Description in Armenian" name="descriptionArm"> </textarea>
          </div>

          <div class="col">
            <label for="descriptionEng">Description in English</label>
            <textarea rows="4" cols="50" v-model="createData.descriptionEng" type="text" placeholder="Description in English" name="descriptionEng"></textarea>
          </div>
        </div>
        <client-only>
          <div class="row">
            <div class="col">
              <label for="descriptionEng">Start Date</label>
              <b-form-datepicker id="datepicker-full-width"
                                 v-model="createData.startDate"
                                 :show-decade-nav="showDecadeNav"
                                 :hide-header="hideHeader"
                                 class="mb-2"
                                 placeholder="Choose a date"
                                 menu-class="w-80"
                                 calendar-width="100%">
              </b-form-datepicker>
            </div>
            <div class="col">
              <label for="descriptionEng">End Date</label>
              <b-form-datepicker id="example-i18n-picker2"
                                 v-model="createData.endDate"
                                 :show-decade-nav="showDecadeNav"
                                 :hide-header="hideHeader"
                                 class="mb-2"
                                 placeholder="Choose a date"
                                 menu-class="w-80"
                                 calendar-width="100%">
              </b-form-datepicker>
            </div>
          </div>
        </client-only>
        <button type="submit" class="thm-btn become-teacher__form-btn">Submit</button>
      </div>
    </form>
  </div>
</template>

<script>
  import https from 'https';

  export default {
    name: 'EditCourse',
    data() {
      return {
        value: '',
        showDecadeNav: true,
        hideHeader: true,
        courseId: null,
        createData: { titleArm: '', titleEng: '', instractorEng: '', instractorArm: '', descriptionArm: '', descriptionEng: '', startDate: '', endDate: '' },
      };
    },
    async created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }

      // Check if a course ID is provided in the route parameters
      if (this.$route.params.id) {
        this.courseId = this.$route.params.id;
        await this.fetchCourseDetails();
      }
    },
    methods: {
      async fetchCourseDetails() {
        try {
          const response = await this.$axios.get(`/api/CourseDetails/${this.courseId}`);
          this.createData = { ...response.data };
        } catch (error) {
          console.error('Error fetching course details:', error);
        }
      },
      async submitForm() {
        try {
          const response = await this.$axios.put(`/api/Courses/Edit/${this.courseId}`, this.createData);
          console.log("response", response);
          if (response) {
            this.$toasted.success('Edit successful!');
            // Redirect after a successful edit
            window.location = "/admin/Course/List";
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
  .form-control {
    height: auto !important;
  }

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
